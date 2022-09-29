using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSnatchGrille : MonoBehaviour
{
    public GameObject SnatchGrill;

    public Transform ParentGrille;

    GameObject DernierSnatchGrillCree;

    public float DistanceEntreSnatch;

    float DistanceParcouru = 100;


    void FixedUpdate()
    {
        DistanceParcouru += Time.deltaTime * ConveyorBelt.TapisRoulantVitesseActuelle;
        //Debug.Log("La distance parcouru est de :" + DistanceParcouru);

        if (DistanceParcouru >= DistanceEntreSnatch)
        {
            if (DernierSnatchGrillCree != null)
            {
                //Debug.Log("Je Change.");
                transform.position = new Vector2(DernierSnatchGrillCree.transform.position.x - DistanceEntreSnatch, transform.position.y);
            }

            DernierSnatchGrillCree = Instantiate(SnatchGrill, transform.position, transform.rotation, ParentGrille);//.GetComponent<SnatchGrill>().Demarrage(DernierSnatchGrillCree, DistanceEntreSnatch);
            DistanceParcouru = 0;
            
        }

        
    }
}
