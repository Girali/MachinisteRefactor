using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canDrop : MonoBehaviour
{
    private bool isInDropZone = false;
    public bool isDragged = false;

    public bool isMoving = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DropZone")
        {
            isInDropZone = true;
            GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255, 1.0f);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DropZone")
        {
            isInDropZone = false;
            if(isDragged)
            {
                GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255, 0.7f);
            }
        }
    }

    public bool inDropZone()
    {
        return isInDropZone;
    }

    void FixedUpdate()
    {
        if (!isDragged && gameObject.tag != "Brick" && isMoving)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(ConveyorBelt.TapisRoulantVitesseActuelle+0.09f, GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
