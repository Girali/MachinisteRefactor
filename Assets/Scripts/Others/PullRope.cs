using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PullRope : MonoBehaviour
{
    public bool effective = false;
    public bool isPulled = false;
    public float startY;
    public float endY;
    float pullLenght;
    bool returning = false;

    public Transform rideauG;
    public Transform rideauD;
    public Transform panel;
    float initPanelY;
    float initRGX;
    float initRDX;
    Vector2 clicPos;

    Rigidbody2D rb;
    private void Start()
    {
        pullLenght = Mathf.Abs(startY - endY);
        initPanelY = panel.position.y;
        initRGX = rideauG.position.x;
        initRDX = rideauD.position.x;
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnMouseDown()
    {
        isPulled = true;
        clicPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDrag()
    {
        if(effective)
        {
            rb.velocity = new Vector2(0, Camera.main.ScreenToWorldPoint(Input.mousePosition).y - clicPos.y) * 0.8f;
            

            if (transform.position.y <= endY)
            {
                transform.position = new Vector2(transform.position.x, endY);
                StartCoroutine("Exit");
            }

            if (transform.position.y >= startY)
            {
                transform.position = new Vector2(transform.position.x, startY);
            }
        }
    }

    private void OnMouseUp()
    {
        isPulled = false;
        rb.velocity = Vector2.zero;
        if(transform.position.y > endY)
        {
            returning = true;
        }
    }

    private void Update()
    {
        if(returning && !isPulled)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, startY, transform.position.z), 0.05f);
            if(transform.position.y >= startY)
            {
                returning = false;
            }
        }
        if(effective)
        {
            panel.position = new Vector2(panel.position.x, initPanelY + (Mathf.Abs(startY - transform.position.y) * 8.7f / pullLenght));
            rideauG.position = new Vector2(initRGX - (Mathf.Abs(startY - transform.position.y) * 10f / pullLenght), rideauG.position.y);
            rideauD.position = new Vector2(initRDX + (Mathf.Abs(startY - transform.position.y) * 10f / pullLenght), rideauD.position.y);
        }
        
    }

    public IEnumerator Enter()
    {
        effective = false;
        yield return new WaitForSeconds(2.5f);
        while(transform.position.y > startY)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, startY, transform.position.z), 0.024f);
            yield return new WaitForEndOfFrame();
        }
        effective = true;
    }

    public IEnumerator Exit()
    {
        effective = false;
        isPulled = false;
        while (transform.position.y < 5.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 5.1f, transform.position.z), 0.1f);
            yield return new WaitForEndOfFrame();
        }

        //Destroy(GameObject.Find("MenuManager"));
        FMOD.Studio.Bus mainBus = FMODUnity.RuntimeManager.GetBus("bus:/");
        mainBus.stopAllEvents(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }




}
