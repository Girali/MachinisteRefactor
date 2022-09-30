using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyGroundcheck : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Brick" && !transform.parent.GetComponent<canDrop>().isDragged && !collision.gameObject.GetComponent<canDrop>().isDragged)
        {
            if (!DialogueManageur.Instance.dialogueDictionary.dialogueObjectHolder[300501].AEteLu)
            {
                DialogueManageur.Instance.ReceptionDialogue(300501);
            }
        }
    }
}
