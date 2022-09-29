using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerTrigger : MonoBehaviour
{
    public UnityEvent<Object> onEnter;
    public UnityEvent<Object> onExit;
    public Collider2D data;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        data = collision;
        onEnter.Invoke(this);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        data = collision;
        onExit.Invoke(this);
    }
}
