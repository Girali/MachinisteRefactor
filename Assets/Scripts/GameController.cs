using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Refactor
{
    public class GameController : MonoBehaviour
    {
        private static GameController _instance = null;

        public static GameController Instance
        {
            get
            {
                if (_instance == null)
                    _instance = FindObjectOfType<GameController>();
                return _instance;
            }
        }

        private Transform[][] grid;
        private List<SceneObject> objectList;
        private Vector2Int gridSize = new Vector2Int(14, 5);
        private Vector2 gridLimitX = new Vector2(-8.5f, 4.5f);
        private Vector2 gridLimitY = new Vector2(-1f, 3f);
        private float gridSpacing = 1f;
        private float speed = 1f;
        private float originalSpeed = 1f;
        private float timeScale = 1f;
        public float distanceDone = 0f;
        public Animator belt;
        public PlayerManager playerManager;
        public DudeManager dudeManager;
        public ParticleSystem confetti;
        public GameObject[] flags;
        public Jun_TweenRuntime largeDropArea;

        public UserInputBox[] userInputBoxes;

        private bool started = false;
        private bool startProgress = false;
        private int gameStep = 0;
        private bool canFail = false;

        private float flagDelay = 12;
        private float from0to1 = 45;
        private float from1to2 = 30;
        private float from2to3 = 30;

        private float frustration = 0;
        private float bordom = 0;

        public int gameState = 1;
        public int gameStateGoalCounter = 1;

        public float TimeScale
        {
            get
            {
                return timeScale;
            }
        }

        public float TimeStep
        {
            get
            {
                return (speed / (float)Application.targetFrameRate) * timeScale;
            }
        }

        public void ChangeToLargeDropArea()
        {
            largeDropArea.Play();
        }

        public void SetGameState(int i)
        {
            gameState = i;
        }

        public void StartStopTime(float t)
        {
            timeScale = t;

            if (timeScale == 0)///stoped
            {
                belt.StartPlayback();
                playerManager.StopStartWalk(false);
            }
            else///started
            {
                belt.StopPlayback();
                playerManager.StopStartWalk(true);
            }
        }

        public void ResetBoringCounter()
        {
            nextBoringCycle = distanceDone + boringCycleLength;
        }

        public void ClearScene()
        {
            foreach (var item in objectList)
            {
                item.GetOutScene();
            }
        }

        private void Awake()
        {
            objectList = new List<SceneObject>();
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 60;
            Time.fixedDeltaTime = 1f / (float)Application.targetFrameRate;
            CreateGrid();
            MusicEventController.Instance.PlayMusicSequence(MusicEventController.Instance.act1Intro, MusicEventController.Instance.act1Loop);
        }

        private void Start()
        {
            EventGameController.Instance.playerGetHit += ResetBoringCounter;
            //EventGameController.Instance.playerGetGrounded += ResetBoringCounter;
            EventGameController.Instance.playerGetFlag += ResetBoringCounter;
            EventGameController.Instance.playerJumpOnBlock += ResetBoringCounter;
            //EventGameController.Instance.playerHeightCheck += ResetBoringCounter;
            EventGameController.Instance.playerOpenChest += ResetBoringCounter;
            EventGameController.Instance.playerKillEnnemy += ResetBoringCounter;

            EventGameController.Instance.playerGetHit += Hit;
            EventGameController.Instance.playerGetGrounded += ResetCombo;
            //EventGameController.Instance.playerGetFlag += ResetBoringCounter;
            EventGameController.Instance.playerJumpOnBlock += JumpCombo;
            EventGameController.Instance.playerHeightCheck += PlayerHeight;
            EventGameController.Instance.playerOpenChest += OpenChest;
            EventGameController.Instance.playerKillEnnemy += EnnemyKilled;
            EventGameController.Instance.playerQuestComplet += CompleteQuest;
            EventGameController.Instance.dudeBoringCycle += Bored;
            EventGameController.Instance.dudeGone += RestartGame;
        }

        public void RestartGame()
        {
            StartCoroutine(RestartCRT());
        }

        private IEnumerator RestartCRT()
        {
            ClearScene();
            yield return new WaitForSeconds(1f);
            Unstuck();
            StartGame();
            StartProgress();
            playerManager.InitMoveSet((PlayerManager.MoveSet)gameState - 1);
        }

        private int jumpCombo = 0;
        private int ennemyCombo = 0;
        private int comboChest = 0;
        private int consecutiveJumps = 0;
        private int consecutiveEnnemies = 0;

        public void ResetCombo()
        {
            jumpCombo = 0;
            ennemyCombo = 0;
        }

        public void PlayerHeight()
        {
            bordom -= 5;
        }

        public void EnnemyKilled()
        {
            ennemyCombo++;
            consecutiveEnnemies++;
            consecutiveJumps = 0;
            if (consecutiveEnnemies <= 3)
            {
                frustration -= 20;
                dudeManager.happy.Play();
            }
        }

        public void Bored()
        {
            bordom += 5;
            ResetBoringCounter();
        }

        public void OpenChest()
        {
            if (comboChest < ennemyCombo + jumpCombo)
            {
                bordom -= 10;
                frustration -= 10;
                comboChest++;
                dudeManager.happy.Play();
            }
            else
            {
                bordom += 5;
                frustration += 5;
            }
        }

        public void CompleteQuest()
        {
            bordom -= 30;
            frustration -= 30;
            dudeManager.happy.Play();
        }

        public bool stucked = false;
        float nextResetByStuck = 0;
        float delayResetByStuck = 3;

        public void Stuck()
        {
            if (!stucked)
            {
                originalSpeed = speed;
                speed = 0;
                stucked = true;
                nextResetByStuck = Time.time + delayResetByStuck;
            }
        }

        public void Unstuck()
        {
            if (stucked)
            {
                nextResetByStuck = 0;
                speed = originalSpeed;
                stucked = false;
            }
        }

        public void JumpCombo()
        {
            jumpCombo++;

            consecutiveJumps++;
            consecutiveEnnemies = 0;

            if (consecutiveEnnemies <= 3)
            {
                bordom -= 5;
                if (jumpCombo > 1)
                {
                    bordom -= 5;
                    dudeManager.happy.Play();
                }
            }
        }

        public void Hit()
        {
            frustration += 20;
            dudeManager.sad.Play();
        }

        public void AddObject(SceneObject s)
        {
            objectList.Add(s);
        }

        private void CreateGrid()
        {
            grid = new Transform[gridSize.x][];
            for (int i = 0; i < gridSize.x; i++)
            {
                grid[i] = new Transform[gridSize.y];
                for (int j = 0; j < gridSize.y; j++)
                {
                    Transform t = new GameObject("Grid " + i + "_" + j).transform;
                    t.parent = transform;
                    t.position = new Vector3((i * gridSpacing) + gridLimitX.x, (j * gridSpacing) + gridLimitY.x, 0);
                    grid[i][j] = t;
                }
            }
        }

        public Transform GetNearestGridPoint(Vector3 v)
        {
            Transform nearest = null;
            float minDist = float.MaxValue;


            for (int x = 0; x < gridSize.x; x++)
            {
                for (int y = 0; y < gridSize.y; y++)
                {
                    Transform t = grid[x][y];

                    if (Vector3.Distance(v, t.position) < minDist)
                    {
                        nearest = t;
                        minDist = Vector3.Distance(v, t.position);
                    }
                }
            }

            return nearest;
        }

        private void Move()
        {
            float moveSpeed = TimeStep;

            if(started)
                distanceDone += moveSpeed;

            foreach (SceneObject t in objectList)
            {
                if (t != null)
                {
                    t.transform.position += new Vector3(moveSpeed, 0, 0);

                    if (t.transform.position.x >= gridLimitX.y + .5f)
                    {
                        t.GetOutScene();
                    }
                }
            }

            for (int x = 0; x < gridSize.x; x++)
            {
                for (int y = 0; y < gridSize.y; y++)
                {
                    Transform t = grid[x][y];
                    t.position += new Vector3(moveSpeed, 0, 0);
                    if (t.position.x >= gridLimitX.y)
                    {
                        t.position -= new Vector3(-gridLimitX.x + gridLimitX.y, 0, 0);
                    }
                }
            }
        }

        public void StartGame()
        {
            playerManager.PlayerReset();
            if (waitForDialogueEnd)
                waitForDialogueEnd = false;
            started = true;
            gameStep = 0;
            distanceDone = 0;
            nextBoringCycle = distanceDone + boringCycleLength;
            jumpCombo = 0;
            ennemyCombo = 0;
            comboChest = 0;
            consecutiveJumps = 0;
            consecutiveEnnemies = 0;
            frustration = 0;
            bordom = 0;
            dudeManager.Init();
        }

        float progressOffset = 0;

        public void StartProgress()
        {
            playerManager.InitMoveSet((PlayerManager.MoveSet)gameState - 1);
            progressOffset = distanceDone;
            startProgress = true;
            canFail = true;
        }

        public void GameOver()
        {
            canFail = false;
            dudeManager.Gone();
            started = false;
            startProgress = false;
        }

        public bool waitForDialogueEnd = false;

        public void Win()
        {
            gameStateGoalCounter++;

            switch (gameState)
            {
                case 1:
                    switch (gameStateGoalCounter)
                    {
                        case 1:
                            break;
                        case 2:
                            DialogueManageur.Instance.ReceptionDialogue(300301);
                            break;
                        case 3:
                            DialogueManageur.Instance.ReceptionDialogue(300401);
                            break;
                        case 4:
                            DialogueManageur.Instance.ReceptionDialogue(302901);
                            gameState = 2;
                            gameStateGoalCounter = 1;
                            waitForDialogueEnd = true;
                            MusicEventController.Instance.PlayMusicSequence(MusicEventController.Instance.act2Intro,MusicEventController.Instance.act2Loop);
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (gameStateGoalCounter)
                    {
                        case 1:
                            break;
                        case 2:
                            DialogueManageur.Instance.ReceptionDialogue(303001);
                            break;
                        case 3:
                            DialogueManageur.Instance.ReceptionDialogue(303101);
                            break;
                        case 4:
                            DialogueManageur.Instance.ReceptionDialogue(303201);
                            gameState = 3;
                            gameStateGoalCounter = 1;
                            waitForDialogueEnd = true;
                            MusicEventController.Instance.PlayMusicSequence(MusicEventController.Instance.act3Intro, MusicEventController.Instance.act3Loop);
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    switch (gameStateGoalCounter)
                    {
                        case 1:
                            break;
                        case 2:
                            DialogueManageur.Instance.ReceptionDialogue(307201);
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            canFail = false;
            dudeManager.Gone();
            confetti.Play(true);
            started = false;
            startProgress = false;
        }

        public void StopGame()
        {
            canFail = false;
            started = false;
        }

        public void FlagCheck()
        {
            SceneObject g;

            switch (gameStep)
            {
                case 0://spawn flag 1
                    if (distanceDone > progressOffset + (from0to1) - flagDelay)
                    {
                        canFail = false;
                        g = Instantiate(flags[0], new Vector3(-9.5f, -1f, 0), Quaternion.identity).GetComponent<SceneObject>();
                        AddObject(g);
                        gameStep++;
                        //do
                    }
                        break;
                case 1://pasted flag 1
                    if (distanceDone > progressOffset + (from0to1))
                    {
                        canFail = true;
                        gameStep++;
                        if (gameState == 1)
                        {
                            Win();
                            //WIN
                        }
                        //do
                    }
                    break;
                case 2://spawn flag 2
                    if (distanceDone > progressOffset + (from0to1 + from1to2) - flagDelay)
                    {
                        canFail = false;
                        g = Instantiate(flags[1], new Vector3(-9.5f, -1f, 0), Quaternion.identity).GetComponent<SceneObject>();
                        AddObject(g);
                        gameStep++;
                        //do
                    }
                    break;
                case 3://pasted flag 2
                    if (distanceDone > progressOffset + (from0to1 + from1to2))
                    {
                        canFail = true;
                        gameStep++;
                        if (gameState == 2)
                        {
                            Win();
                            //WIN
                        }
                        //do
                    }
                    break;
                case 4://spawn flag 3
                    if (distanceDone > progressOffset + (from0to1 + from1to2 + from2to3) - flagDelay)
                    {
                        canFail = false;
                        g = Instantiate(flags[2], new Vector3(-9.5f, -1.1f, 0), Quaternion.identity).GetComponent<SceneObject>();
                        AddObject(g);
                        gameStep++;
                        //do
                    }
                    break;
                case 5://pasted flag 3
                    if (distanceDone > progressOffset + (from0to1 + from1to2 + from2to3))
                    {
                        canFail = false;
                        gameStep++;
                        if (gameState == 3)
                        {
                            Win();
                            //WIN
                        }
                        //do
                    }
                    break;
                default:
                    break;
            }

        }

        private float nextBoringCycle = 0;
        private float boringCycleLength = 10;

        private void BoringCycle()
        {
            if(distanceDone > nextBoringCycle)
            {
                EventGameController.Instance.dudeBoringCycle();
            }
        }

        private void GameLogic()
        {
            if (frustration == 100 || bordom == 100)
            {
                if (canFail)
                {
                    GameOver();
                }
                else
                {
                    ClearScene();
                    Unstuck();
                    playerManager.InitMoveSet((PlayerManager.MoveSet)gameState - 1);
                    frustration = 0;
                    bordom = 0;
                }
            }

        }

        public void Update()
        {
            Move();
            playerManager.Move(TimeStep);
            if(startProgress)
                FlagCheck();
            BoringCycle();

            frustration = Mathf.Clamp(frustration, 0, 100);
            bordom = Mathf.Clamp(bordom, 0, 100);

            dudeManager.Move(frustration, bordom);

            if (stucked)
            {
                if (nextResetByStuck != 0 && Time.time > nextResetByStuck)
                {
                    frustration = 100;
                }
            }

            GameLogic();

        }
    }
}
