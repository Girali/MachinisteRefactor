using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Refactor
{
    public class EventGameController : MonoBehaviour
    {

        private static EventGameController _instance;
        public static EventGameController Instance
        {
            get
            {
                if (_instance == null)
                    _instance = FindObjectOfType<EventGameController>();

                return _instance;
            }
        }

        private bool fistTimePlaced = true;


        public void NotifyUserPlaceElement(SceneObject o)
        {
            if(fistTimePlaced)
            {
                DialogueManageur.Instance.ReceptionDialogue(300201);
                fistTimePlaced = false;
            }
            else
            {
                switch (o.type)
                {
                    case SceneObjectType.Block:
                        break;
                    case SceneObjectType.Ennemy:
                        break;
                    case SceneObjectType.Chest:
                        break;
                    case SceneObjectType.Quest:
                        break;
                    default:
                        break;
                }
            }
        }

        public void NotifyDialogueEndEvent(DialogueObject o)
        {
            switch (o.ID)
            {
                case 606803:
                    GameObject.Find("corde").GetComponent<PullRope>().StartCoroutine("Enter");
                    break;
                case 600104:
                    GameController.Instance.dudeManager.Init();
                    break;
                case 600107:
                    GameController.Instance.userInputBoxes[0].OpenClose(true);
                    GameController.Instance.userInputBoxes[1].OpenClose(true);
                    GameController.Instance.StartGame();
                    break;
                case 600208:
                    GameController.Instance.GameOver();
                    GameController.Instance.SetGameState(1);
                    break;
                case 602904:
                    GameController.Instance.userInputBoxes[2].OpenClose(true);
                    break;
                case 602908:
                    GameController.Instance.StartGame();
                    GameController.Instance.StartProgress();
                    break;
                case 603209:
                    GameController.Instance.ChangeToLargeDropArea();
                    break;
                case 603211:
                    GameController.Instance.StartGame();
                    GameController.Instance.StartProgress();
                    break;
                case 607309:
                    GameController.Instance.LaunchCredits();
                    break;
                default:
                    break;
            }
        }

        public UnityAction playerGetHit;
        public UnityAction playerGetGrounded;
        public UnityAction playerGetFlag;
        public UnityAction playerJumpOnBlock;
        public UnityAction playerHeightCheck;
        public UnityAction playerOpenChest;
        public UnityAction playerKillEnnemy;
        public UnityAction playerQuestComplet;
        public UnityAction playerStuck;

        public UnityAction dudeBoringCycle;
        public UnityAction dudeGone;

        private void Awake()
        {
            playerGetHit += EventDebug;
            playerGetGrounded += EventDebug;
            playerGetFlag += EventDebug;
            playerJumpOnBlock += EventDebug;
            playerHeightCheck += EventDebug;
            playerOpenChest += EventDebug;
            playerKillEnnemy += EventDebug;
            playerQuestComplet += EventDebug;
            playerStuck += EventDebug;

            dudeBoringCycle += EventDebug;
            dudeGone += EventDebug;
        }

        public void EventDebug()
        {
            System.Diagnostics.StackTrace stackTrace = new System.Diagnostics.StackTrace();
            System.Reflection.MethodBase methodBase = stackTrace.GetFrame(1).GetMethod();
            string typeName = methodBase.DeclaringType.Name;
            string methodName = methodBase.Name;
            Debug.Log(typeName + "  " + methodName);
        }
    }
}