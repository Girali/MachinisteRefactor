using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Refactor;

public class DialogueManageur : MonoBehaviour
{
    public DialogueDictionary dialogueDictionary;
    public TMP_Text text;
    public bool Menu = false;
    public float TempsDernierDialogue;
    public float TempsEntreSilence = 8.0f;
    public bool EnPlaytest = true;
    public List<DialogueObject> ListeTampon = new List<DialogueObject>();
    public bool DialogueEnCours = false;

    private List<DialogueObject> ListePriorite = new List<DialogueObject>();
    private int PrioriteMax = 0;
    private int PrioriteTeste;
    private DialogueObject DialogueALancer;
    private DialogueObject DialogueSuivant;
    private DialogueObject DialogueADire;
    private IEnumerator coroutine;
    private Animator machiniste;

    private static DialogueManageur _instance;
    public static DialogueManageur Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<DialogueManageur>();

            return _instance;
        }
    }

    private void Start()
    {
        TempsDernierDialogue = Time.time;

        if(GameObject.Find("machiniste in_game") != null)
        {
            machiniste = GameObject.Find("machiniste in_game").GetComponent<Animator>();
        }
    }

    public void ReceptionDialogue(int tag)
    {
        DialogueObject d = dialogueDictionary.dialogueObjectHolder[tag];
        ListeTampon.Add(d);

        coroutine = TamponNettoyeur(d);
        StartCoroutine(coroutine);

        LanceurDialogue();
    }

    private void LanceurDialogue()
    {
        if (DialogueEnCours == true)
        {
            return;
        }

        if (ListeTampon.Count == 0)
        {
            return;
        }

        ListePriorite.Clear();
        PrioriteMax = -10;

        foreach (DialogueObject item in ListeTampon)
        {
            PrioriteTeste = item.Priorite;

            if (PrioriteTeste >= PrioriteMax)
            {
                if (PrioriteTeste > PrioriteMax)
                {
                    ListePriorite.Clear();
                    PrioriteMax = PrioriteTeste;
                }

                ListePriorite.Add(item);
            }
        }


        if (ListePriorite.Count == 1)
            DialogueALancer = ListePriorite[0];
        else
            DialogueALancer = ListePriorite[Random.Range(0, ListePriorite.Count)];

        while (ListeTampon.Remove(DialogueALancer));

        coroutine = CRAfficheurDialogue(DialogueALancer);

        StartCoroutine(coroutine);

        DialogueSuivant = DialogueALancer.TagDialogueSuivant;

        if (DialogueSuivant == null)
            return;

        if (DialogueSuivant.ID == 0)
            return;

        ListeTampon.Add(DialogueSuivant);

        coroutine = TamponNettoyeur(DialogueSuivant);

        StartCoroutine(coroutine);
    }

    private IEnumerator CRAfficheurDialogue(DialogueObject tag)
    {
        DialogueEnCours = true;

        DialogueADire = tag;

        //if (tag.ID >= 200000 && tag.ID < 300000)
        //{
        //    ProgressionManageur.PM.NbConversationsSTNPDites++;
        //}

        yield return new WaitForSeconds(DialogueADire.TempsPreDialogue);

        if (DialogueADire.SonDialogue != "event:/Test/")
        {
            FMODUnity.RuntimeManager.PlayOneShot(DialogueADire.SonDialogue);
        }

        if (DialogueADire.EvenementSpecial)
        {
            EventGameController.Instance.NotifyDialogueEndEvent(tag);
            Debug.LogError(tag.ID);
            //GetComponent<EvenementDialogueManageur>().EDM.EvenementSpeciaux(tag);
        }

        //Afficher DialogueADire.TextDialogue
        text.text = DialogueADire.TexteDialogue;
        if(machiniste != null)
        {
            machiniste.SetTrigger("Talk");
        }
        

        //Debug.Log(DialogueADire.TexteDialogue);  

        //Debug.Log(DialogueADire.SonDialogue);

        DialogueADire.AEteLu = true;

        yield return new WaitForSeconds(DialogueADire.TempsDialogue+0.75f);

        text.text = "";//Desafficher Dialogue
        if (machiniste != null)
        {
            machiniste.SetTrigger("Talk");
        }
            

        yield return new WaitForSeconds(DialogueADire.TempsPostDialogue);

        DialogueEnCours = false;

        TempsDernierDialogue = Time.time;

        LanceurDialogue();
    }




    // <3 private void OnCoinllisionEnter(Coinllision coinllision) coin; 



    private IEnumerator TamponNettoyeur(DialogueObject tag)
    {
        yield return new WaitForSeconds(tag.DelaiTampon);

        ListeTampon.Remove(tag);
    }
}
