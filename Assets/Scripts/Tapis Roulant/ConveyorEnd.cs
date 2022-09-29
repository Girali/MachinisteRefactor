using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorEnd : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<canDrop>() != null)
        {
            if (!collision.GetComponent<canDrop>().isDragged)
            {
                if(collision.gameObject.tag == "Chest")
                {
                    if(collision.GetComponent<Chest>().CanOpen())
                    {
                        GameObject.Find("Targets").GetComponent<IncomfortManager>().ChestMissed();
                    }
                }
                if (collision.gameObject.tag == "Hostile")
                {
                    if(GameObject.Find("BrickSlot (1)").GetComponent<DragDrop>().harpagonsOnConveyor > 0)
                    {
                        GameObject.Find("BrickSlot (1)").GetComponent<DragDrop>().harpagonsOnConveyor--;
                    }
                    
                }
                Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
                rb.gravityScale = 1;
                rb.constraints = RigidbodyConstraints2D.None;
                rb.bodyType = RigidbodyType2D.Dynamic;
                collision.gameObject.transform.parent = null;
                collision.GetComponent<canDrop>().isMoving = false;
            }
        }
        
    }
}
