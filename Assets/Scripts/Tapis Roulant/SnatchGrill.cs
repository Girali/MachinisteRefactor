using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnatchGrill : MonoBehaviour
{
    Rigidbody2D rb;

    GameObject LeGarsDeDevant;

    float LaDistance;

    IEnumerator coroutine;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(ConveyorBelt.TapisRoulantVitesseActuelle, 0);

        coroutine = FixGrille();
        StartCoroutine(coroutine);

    }

    /*

    public GameObject Demarrage(GameObject SnatchDeDevant, float Distance)
    {
        rb = GetComponent<Rigidbody2D>();

        if (SnatchDeDevant == null)
        {
            //Debug.Log("Quoi ?");
            return this.gameObject;
        }

        //LeGarsDeDevant = SnatchDeDevant;

        //LaDistance = Distance;

        //Debug.Log("Le greed précédent est à "+ SnatchDeDevant.transform.position.x + " et je vais créer à cette unité à" + (SnatchDeDevant.transform.position.x - Distance) );

        //float XdeDebut = (SnatchDeDevant.transform.position.x - Distance);

        //transform.position = new Vector2(XdeDebut, transform.position.y);

        //rb.MovePosition(new Vector2(XdeDebut, transform.position.y));

        //rb.MovePosition(new Vector2(XdeDebut + 4*(Time.deltaTime * ConveyorBelt.TapisRoulantVitesseActuelle), transform.position.y));

        return this.gameObject;
    }
    */
    
    
    private void FixedUpdate()
    {
        //rb.MovePosition(new Vector2(transform.position.x + Time.deltaTime * ConveyorBelt.TapisRoulantVitesseActuelle, transform.position.y));
        rb.velocity = new Vector2(ConveyorBelt.TapisRoulantVitesseActuelle, 0);

        
    }

    IEnumerator FixGrille()
    {
        yield return new WaitForFixedUpdate();
        //yield return new WaitForEndOfFrame();
        rb.MovePosition( new Vector2(transform.position.x + 2*(rb.velocity.x * Time.deltaTime), transform.position.y));

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ConveyorEnd")
        {
            Destroy(this.gameObject);
        }
    }

}
