using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SansTriggerDialogue : MonoBehaviour
{

    List<int> TableauRandomDialogue = new List<int>();

    int DialogueAEnvoyer;

    bool ARajouterDansDialogue = true;


    //TEMPORAIRE

   


    void Update()
    {


        if (Time.time >= (GetComponent<DialogueManageur>().TempsDernierDialogue + GetComponent<DialogueManageur>().TempsEntreSilence) && !GetComponent<DialogueManageur>().DialogueEnCours)
        {
            SelectionDialoguePrioritaire();
        }
    }

    private void SelectionDialoguePrioritaire()
    {
        
        if (TableauRandomDialogue.Count > 0)
        {
            TableauRandomDialogue.Clear();
        }


        //foreach (KeyValuePair<int, Dialogue> item in Un_DicoDialogue.DicoDialogue1)
        //{
        //    ListeTest(item.Value, item.Key);
        //}


        if (TableauRandomDialogue.Count == 0)
        {
            //SelectionDialogueNonPrioritaire qui arrive si il ny a pas de dialogue prioritaire
            //foreach (KeyValuePair<int, Dialogue> item in Deux_DicoDialogue.DicoDialogue2)
            //{
            //    ListeTest(item.Value, item.Key);
            //}
        }

        if (TableauRandomDialogue.Count == 0)
        {
            GetComponent<DialogueManageur>().TempsDernierDialogue += 8.0f;
            return;
        }

        DialogueAEnvoyer = TableauRandomDialogue[Random.Range(0, TableauRandomDialogue.Count)];

        DialogueManageur.Instance.ReceptionDialogue(DialogueAEnvoyer);
    }

    private void ListeTest(DialogueObject item, int KeyItem)
    {

        ARajouterDansDialogue = true;

        if (item.Desactive)
        {
            ARajouterDansDialogue = false;
        }


        if (item.NeDoitEtreLuQuUneFois && item.AEteLu)
        {
            ARajouterDansDialogue = false;
        }


        if (item.DoiventEtreLu.Count != 0)
        {
            foreach (DialogueObject Atester in item.DoiventEtreLu)
            {
                if (!Atester.AEteLu)
                {
                    ARajouterDansDialogue = false;
                }
            }
        }

        if (item.AucuneBriqueNestPose)
        {
            if (DragDrop.dropCount != 0)
            {
                ARajouterDansDialogue = false;
            }
        }

        if (item.NbDialogueSTNPMinimumDit > ProgressionManageur.PM.NbConversationsSTNPDites)
        {
            ARajouterDansDialogue = false;
        }






        if (ARajouterDansDialogue)
        {
            TableauRandomDialogue.Add(KeyItem);
        }




    }
}
