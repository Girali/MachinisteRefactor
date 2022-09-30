using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenementDialogueManageur : MonoBehaviour
{

    public GameObject AActiverQuandBoitesSouvrent;

    public EvenementDialogueManageur EDM;

    TargetManager TM;
    void Awake()
    {

        if(GameObject.Find("Targets") != null)
        {
            TM = GameObject.Find("Targets").GetComponent<TargetManager>();
        }
        
    }

    public void EvenementSpeciaux(DialogueObject t)
    {
        int tag = t.ID;

        if (tag == 600104)
        {
            //Faire apparaitre la première cible du jeu. (se declenche apres quelques premiers dialogues du Machiniste)
            ProgressionManageur.PM.PremierPersoApparition.SetActive(true);
            TM.StartCoroutine("NextTarget");
            return;

        }

        if (tag == 600107)
        {
            //ProgressionManageur.PM.EnableDrop();
            ProgressionManageur.PM.OpenBoxes1();
            return;

        }

        if (tag == 600202)
        {
            //Changer un booléen qui fait que les discussion triggerable taquine peuvent se lancer.
            return;
        }

        if (tag == 302901)
        {
            //Désactiver l'entrée des cibles (correspond au passage du pallier 2) (possibilité de le faire en meme temps que le lancement de ce dialogue)
            TM.StartCoroutine("NoTarget");
            return;
        }

        if (tag == 602904)
        {
            ProgressionManageur.PM.OpenBoxes2();
            return;
        }


        if (tag == 602908)
        {
            //Faire apparaitre les premiere cible du pallier 2
            TM.TargetPaused = false;
            TM.StartCoroutine("NextTarget");
            return;
        }

        if (tag == 303201)
        {
            //Empecher les cibles d'arriver (passage au pallier 3)
            TM.StartCoroutine("NoTarget");
            return;
        }

        if (tag == 603206)
        {
            //Ouvrir coffre Arlequin
            ProgressionManageur.PM.OpenBoxes3();
            return;
        }

        if (tag == 603209)
        {
            //Faire remonter l'UI pour poser les objets et permettre de poser nimporte où
            ProgressionManageur.PM.StartCoroutine("RemoveDropZone");
        }

        if (tag == 603211)
        {
            //Le premier streameur qui débarque en flexant, le guedin
            TM.TargetPaused = false;
            TM.StartCoroutine("NextTarget");
            return;
        }

        if(tag == 606803)
        {
            GameObject.Find("corde").GetComponent<PullRope>().StartCoroutine("Enter");
        }

        if(tag == 307201)
        {
            //FIN N°1
            TM.StartCoroutine("NoTarget");
        }

        if (tag == 607309)
        {
            //Clear la liste tampon et Lancer une boucle qui lance un generique au momement où dialogue en cours passe en false
        }

        if (tag == 307201)
        {
            //Desactiver larrivée de nouveaux streameurs (c'est quand la fin est déclenché)
            TM.StartCoroutine("NoTarget");
        }



    }

}
