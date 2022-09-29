using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public bool isMoving = true;
    public bool isPaused = false;

    public static float TapisRoulantVitesseActuelle = 1f;
    float tempSpeed = TapisRoulantVitesseActuelle;

    public Animator Machiniste;

    private void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isMoving)
            {
                isPaused = true;
                GameObject.Find("Actor").GetComponent<Rigidbody2D>().simulated = false;
                SetOff();
            } else
            {
                isPaused = false;
                GameObject.Find("Actor").GetComponent<Rigidbody2D>().simulated = true;
                SetOn();
            }
        }
        transform.parent.GetComponent<Animator>().SetBool("move", isMoving);
        Machiniste.SetBool("Move", isMoving);
        /*
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(!isPaused)
            {
                TapisRoulantVitesseActuelle += 0.1f;
                tempSpeed = TapisRoulantVitesseActuelle;
            } else
            {
                tempSpeed += 0.2f;
            }
            Debug.Log(TapisRoulantVitesseActuelle);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (!isPaused)
            {
                TapisRoulantVitesseActuelle -= 0.1f;
                tempSpeed = TapisRoulantVitesseActuelle;
            }
            else
            {
                tempSpeed -= 0.2f;
            }
            Debug.Log(TapisRoulantVitesseActuelle);
        }*/

    }

    public void SetOff()
    {
        //GetComponent<Animator>().SetBool("move", false);
        isMoving = false;
        TapisRoulantVitesseActuelle = 0;
    }

    public void SetOn()
    {
        //GetComponent<Animator>().SetBool("move", true);
        isMoving = true;
        TapisRoulantVitesseActuelle = tempSpeed;
    }


}
