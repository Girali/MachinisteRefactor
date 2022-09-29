using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private Camera cam;
    public GameObject prefab;
    private GameObject brick;
    public Transform tapisRoulant;
    IncomfortManager target;

    public GameObject Grille;

    public  bool closed = true;

    float distanceVerifie;

    float distanceMax;

    Transform GrilleLaPlusProche;

    static public int dropCount;
    public int harpagonsOnConveyor = 0;

    private void Start()
    {
        cam = Camera.main;
        target = GameObject.Find("Targets").GetComponent<IncomfortManager>();
    }
    public void OnMouseDown()
    {
        if (closed)
            //Petit ajout pour que au debut du jeu on ne puisse pas drag&drop
        {
            return;
        }

        FMODUnity.RuntimeManager.PlayOneShot("event:/SD/DragBrick");
        Vector3 pos = cam.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        brick = Instantiate(prefab, pos, Quaternion.identity);
        brick.GetComponent<canDrop>().isDragged = true;
    }

    public void OnMouseUp()
    {
        if (closed)
        //Petit ajout pour que au debut du jeu on ne puisse pas drag&drop
        {
            return;
        }
        GameObject.Find("Targets").GetComponent<IncomfortManager>().firstBlocDropped = true;
        brick.GetComponent<BoxCollider2D>().enabled = true;
        brick.GetComponent<canDrop>().isDragged = false;

        if (!brick.GetComponent<canDrop>().inDropZone())
        {
            if(brick.gameObject.tag == "Ally")
            {
                Destroy(brick.GetComponent<QuestGiver>().bubble);
            }
            Destroy(brick);
        } else
        {
            if (brick.gameObject.tag == "Brick")
            {
                brick.layer = LayerMask.NameToLayer("Platform");
                distanceMax = 10000;

                foreach ( Transform child in Grille.transform)
                {
                    distanceVerifie = Vector3.Distance(child.transform.position, brick.transform.position);

                    if (distanceVerifie < distanceMax)
                    {
                        distanceMax = distanceVerifie;
                        GrilleLaPlusProche = child.transform;
                    }
                }

                brick.transform.position = GrilleLaPlusProche.position;
            } 

            if (brick.GetComponent<BoxCollider2D>() != null)
            {
                brick.GetComponent<BoxCollider2D>().isTrigger = false;
            }
            if(brick.tag == "Brick")
            {
                brick.transform.parent = GrilleLaPlusProche;
            } else
            {
                brick.transform.parent = tapisRoulant;
            }

            brick.GetComponent<Rigidbody2D>().gravityScale = 1;
            brick.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -7);
            switch (brick.tag)
            {
                case "Brick":
                    target.blocDrop();
                    FMODUnity.RuntimeManager.PlayOneShot("event:/SD/DropBloc");
                    break;
                case "Hostile":
                    target.ennemyDrop();
                    FMODUnity.RuntimeManager.PlayOneShot("event:/SD/DropHarpagon");
                    harpagonsOnConveyor++;
                    if(harpagonsOnConveyor >= 10 && !DialogueManageur.Instance.TrouverDialogueAvecTag(300901).AEteLu)
                    {
                        DialogueManageur.Instance.ReceptionDialogue(300901);
                    }
                    if (harpagonsOnConveyor >= 20 && !DialogueManageur.Instance.TrouverDialogueAvecTag(301001).AEteLu)
                    {
                        DialogueManageur.Instance.ReceptionDialogue(301001);
                    }
                    break;
                case "Chest":
                    target.chestDrop();
                    break;
                case "Ally":
                    target.allyDrop();
                    break;
            }
            dropCount++;
            if(dropCount == 1)
            {
                DialogueManageur.Instance.ReceptionDialogue(300201);
            }
        }
    }

    public void OnMouseDrag()
    {
        if (closed)
        //Petit ajout pour que au debut du jeu on ne puisse pas drag&drop
        {
            return;
        }

        Vector3 pos = cam.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        if(brick != null)
        {
            brick.transform.position = pos;
        }
        
    }

    
}
