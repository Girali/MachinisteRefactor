using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFallingObjects : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( (collision.gameObject.tag == "Brick" || collision.gameObject.layer == LayerMask.NameToLayer("Interactible")) && !collision.GetComponent<canDrop>().isDragged)
        {
            Destroy(collision.gameObject);
        }
    }
}
