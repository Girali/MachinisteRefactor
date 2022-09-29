using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDetector : MonoBehaviour
{
    List<GameObject> collisionList = new List<GameObject>();

    public float timeBeforeStuck = 10;
    float currentTimeStuck = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Brick")
        {
            collisionList.Add(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Brick")
        {
            if(collisionList.Contains(collision.gameObject))
            {
                collisionList.Remove(collision.gameObject);
            }
        }
    }

    private void Update()
    {
        if(collisionList.Count > 0)
        {
            transform.parent.GetComponent<ControlActor>().conveyor.SetOff();
            if(!transform.parent.GetComponent<ControlActor>().conveyor.isPaused)
            {
                currentTimeStuck += Time.deltaTime;
                if (currentTimeStuck >= timeBeforeStuck)
                {
                    currentTimeStuck = 0;
                    GameObject.Find("Targets").GetComponent<IncomfortManager>().ActorStuck();
                }
            } 
        } else
        {
            if (!transform.parent.GetComponent<ControlActor>().conveyor.isPaused && GameObject.Find("Targets").GetComponent<TargetManager>().actor.typeMouvement != ControlActor.MoveCode.None)
            {
                transform.parent.GetComponent<ControlActor>().conveyor.SetOn();
                currentTimeStuck = 0;
            }
        }
    }
}
