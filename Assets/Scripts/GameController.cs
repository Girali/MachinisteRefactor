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
        private float timeScale = 1f;
        private float distanceDone = 0f;
        public Animator belt;
        public PlayerManager playerManager;
        public DudeManager dudeManager;
        public GameObject[] flags;

        private int gameStep = 0;
        private bool canFail = false;

        private float flagDelay = 12;
        private float from0to1 = 45;
        private float from1to2 = 30;
        private float from2to3 = 30;

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

        private void Awake()
        {
            objectList = new List<SceneObject>();
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 60;
            Time.fixedDeltaTime = 1f / (float)Application.targetFrameRate;
            CreateGrid();
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
            canFail = true;
            gameStep = 0;
            distanceDone = 0;
        }

        public void FailGame()
        {
            canFail = false;
        }

        public void FlagCheck()
        {
            SceneObject g;

            switch (gameStep)
            {
                case 0://spawn flag 1
                    if (distanceDone > (from0to1) - flagDelay)
                    {
                        canFail = false;
                        g = Instantiate(flags[0], new Vector3(-9.5f, -1f, 0), Quaternion.identity).GetComponent<SceneObject>();
                        AddObject(g);
                        gameStep++;
                        //do
                    }
                        break;
                case 1://pasted flag 1
                    if (distanceDone > (from0to1))
                    {
                        canFail = true;
                        gameStep++;
                        //do
                    }
                    break;
                case 2://spawn flag 2
                    if (distanceDone > (from0to1 + from1to2) - flagDelay)
                    {
                        canFail = false;
                        g = Instantiate(flags[1], new Vector3(-9.5f, -1f, 0), Quaternion.identity).GetComponent<SceneObject>();
                        AddObject(g);
                        gameStep++;
                        //do
                    }
                    break;
                case 3://pasted flag 2
                    if (distanceDone > (from0to1 + from1to2))
                    {
                        canFail = true;
                        gameStep++;
                        //do
                    }
                    break;
                case 4://spawn flag 3
                    if (distanceDone > (from0to1 + from1to2 + from2to3) - flagDelay)
                    {
                        canFail = false;
                        g = Instantiate(flags[2], new Vector3(-9.5f, -1.1f, 0), Quaternion.identity).GetComponent<SceneObject>();
                        AddObject(g);
                        gameStep++;
                        //do
                    }
                    break;
                case 5://pasted flag 3
                    if (distanceDone > (from0to1 + from1to2 + from2to3))
                    {
                        canFail = false;
                        gameStep++;
                        //do
                    }
                    break;
                default:
                    break;
            }

        }

        public void Update()
        {
            Move();
            playerManager.Move(TimeStep);
            FlagCheck();
        }
    }
}
