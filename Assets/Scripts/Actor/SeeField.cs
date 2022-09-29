using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeField : MonoBehaviour
{
    public List<Transform> seenObjects;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Brick" || collision.gameObject.tag == "Ally" || collision.gameObject.tag == "Chest" || collision.gameObject.tag == "Hostile")
        {
            seenObjects.Add(collision.transform);
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Brick" || collision.gameObject.tag == "Ally" || collision.gameObject.tag == "Chest" || collision.gameObject.tag == "Hostile")
        {
            seenObjects.Remove(collision.transform);
        }
    }
}
