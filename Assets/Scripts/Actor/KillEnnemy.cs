using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FirstGearGames.SmoothCameraShaker;

public class KillEnnemy : MonoBehaviour
{
    ControlActor actor;
    QuestManager questManager;
    public float ennemyKillBounce = 4;
    public ShakeData killShake;
    // Start is called before the first frame update
    void Start()
    {
        actor = transform.parent.GetComponent<ControlActor>();
        questManager = transform.parent.GetComponent<QuestManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "EnnemyHead" && actor.GetComponent<ControlActor>().isFalling)
        {
            if (!collision.transform.parent.GetComponent<canDrop>().isDragged)
            {
                CameraShakerHandler.Shake(killShake);
                collision.transform.parent.GetComponent<Animator>().SetTrigger("Dead");
                collision.transform.parent.tag = "Untagged";
                GameObject.Find("BrickSlot (1)").GetComponent<DragDrop>().harpagonsOnConveyor--;
                actor.GetComponent<ControlActor>().Jump(ennemyKillBounce);
                GameObject.Find("Targets").GetComponent<IncomfortManager>().EnnemyKilled();
                if (questManager.objType == QuestGiver.QuestType.Kill && questManager.activeQuest)
                {
                    questManager.currentNb++;
                }
            }
            
        }
    }
}
