using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FirstGearGames.SmoothCameraShaker;

public class InteractibleDetector : MonoBehaviour
{
    ControlActor actor;
    QuestManager questManager;
    TargetManager TM;
    public ShakeData ennemyHitShake;
    private void Start()
    {
        actor = transform.parent.GetComponent<ControlActor>();
        questManager = transform.parent.GetComponent<QuestManager>();
        TM = GameObject.Find("Targets").GetComponent<TargetManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Hostile" && !actor.Invincible())
        {
            if (!collision.GetComponent<canDrop>().isDragged)
            {
                GameObject.Find("Targets").GetComponent<IncomfortManager>().EnnemyHit();
                CameraShakerHandler.Shake(ennemyHitShake);
                actor.StartCoroutine("HitBlink");
            }
        }

        if(collision.gameObject.tag == "Chest")
        {
            if(!collision.GetComponent<canDrop>().isDragged)
            {
                if (collision.GetComponent<Chest>().CanOpen())
                {
                    collision.GetComponent<Chest>().Open();
                    GameObject.Find("Targets").GetComponent<IncomfortManager>().ChestOpen();
                    if (questManager.objType == QuestGiver.QuestType.Collect && questManager.activeQuest)
                    {
                        questManager.currentNb++;
                    }
                }
            }
            
        }

        if(collision.gameObject.tag == "Ally")
        {
            if (!collision.GetComponent<canDrop>().isDragged)
            {
                QuestGiver quest = collision.GetComponent<QuestGiver>();
                if (questManager.WantToTakeQuest() && !quest.questGiven)
                {
                    quest.questGiven = true;
                    questManager.TakeQuest(quest.objectiveNumber, quest.objectiveType);
                }
            }
               
        }

        if (collision.gameObject.tag == "Flag")
        {
            if (TM.timeSpent > TM.timeToValidateStage3)
            {
                switch (Random.Range(1, 4))
                {
                    case 1:
                        DialogueManageur.Instance.ReceptionDialogue(304201);
                        break;
                    case 2:
                        DialogueManageur.Instance.ReceptionDialogue(304301);
                        break;
                    case 3:
                        DialogueManageur.Instance.ReceptionDialogue(304401);
                        break;
                }
            } else if (TM.timeSpent > TM.timeToValidateStage2)
            {
                switch (Random.Range(1, 4))
                {
                    case 1:
                        DialogueManageur.Instance.ReceptionDialogue(303901);
                        break;
                    case 2:
                        DialogueManageur.Instance.ReceptionDialogue(304001);
                        break;
                    case 3:
                        DialogueManageur.Instance.ReceptionDialogue(304101);
                        break;
                }
            } else if (TM.timeSpent > TM.timeToValidateStage1)
            {
                Debug.Log("drapeau1");
                switch (Random.Range(1, 4))
                {
                    case 1:
                        DialogueManageur.Instance.ReceptionDialogue(303601);
                        break;
                    case 2:
                        DialogueManageur.Instance.ReceptionDialogue(303701);
                        break;
                    case 3:
                        DialogueManageur.Instance.ReceptionDialogue(303801);
                        break;
                }
            }

            

            
        }
    }
}
