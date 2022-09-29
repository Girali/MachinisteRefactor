using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    bool isOpened = false;
    
    public bool CanOpen ()
    {
        return !isOpened;
    }

    public void Open()
    {
        isOpened = true;
        GetComponent<Animator>().SetTrigger("Open");
    }
}
