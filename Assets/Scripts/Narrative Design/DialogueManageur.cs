using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManageur : MonoBehaviour
{
    public TMP_Text text;
    public bool Menu = false;
    public float TempsDernierDialogue;
    public float TempsEntreSilence = 8.0f;
    public bool EnPlaytest = true;
    public List<int> ListeTampon = new List<int>();
    public bool DialogueEnCours = false;

    private List<int> ListePriorite = new List<int>();
    private int PrioriteMax = 0;
    private int PrioriteTeste;
    private int DialogueALancer;
    private int DialogueSuivant;
    private Dialogue DialogueADire;
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

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
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
        ListeTampon.Add(tag);


        coroutine = TamponNettoyeur(tag);

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

        foreach (int item in ListeTampon)
        {
            PrioriteTeste = TrouverDialogueAvecTag(item).Priorite;

            //Debug.Log("On test le dialogue " + item + " qui a la priorité " + PrioriteTeste + " alors que la priorité max actuelle est de " + PrioriteMax);

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
        {
            DialogueALancer = ListePriorite[0];
        }
        else
        {
            DialogueALancer = ListePriorite[Random.Range(0, ListePriorite.Count)];
        }

        while (ListeTampon.Remove(DialogueALancer)) ;

        coroutine = CRAfficheurDialogue(DialogueALancer);

        StartCoroutine(coroutine);

        DialogueSuivant = TrouverDialogueAvecTag(DialogueALancer).TagDialogueSuivant;

        if (DialogueSuivant == 0)
        {
            return;
        }

        ListeTampon.Add(DialogueSuivant);

        coroutine = TamponNettoyeur(DialogueSuivant);

        StartCoroutine(coroutine);
    }




    public Dialogue TrouverDialogueAvecTag(int tag)
    {
        //Debug.Log("TrouverDialogueAvecTag a reçu une requête pour le tag "+ tag);

        if (tag >= 100000 && tag < 200000)
        {
            //return Un_DicoDialogue.DicoDialogue1[tag];
        }

        if (tag >= 200000 && tag < 300000)
        {
            //return Deux_DicoDialogue.DicoDialogue2[tag];
        }

        if (tag >= 300000 && tag < 400000)
        {
            //return Dico3.DicoDialogue3[tag];
        }

        if (tag >= 400000 && tag < 500000)
        {
            //return Quatre_DicoDialogue.DicoDialogue4[tag];
        }

        if (tag >= 500000 && tag < 600000)
        {
            //return Cinq_DicoDialogue.DicoDialogue5[tag];
        }

        if (tag >= 600000 && tag < 700000)
        {
            //return Dico6.DicoDialogue6[tag];
        }

        return null;
    }





    private IEnumerator CRAfficheurDialogue(int tag)
    {
        DialogueEnCours = true;

        DialogueADire = TrouverDialogueAvecTag(tag);

        if (tag >= 200000 && tag < 300000)
        {
            ProgressionManageur.PM.NbConversationsSTNPDites++;
        }

        yield return new WaitForSeconds(DialogueADire.TempsPreDialogue);

        if (DialogueADire.SonDialogue != "event:/Test/")
        {
            FMODUnity.RuntimeManager.PlayOneShot(DialogueADire.SonDialogue);
        }

        if (DialogueADire.EvenementSpecial)
        {
            GetComponent<EvenementDialogueManageur>().EDM.EvenementSpeciaux(tag);
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



    private IEnumerator TamponNettoyeur(int tag)
    {
        yield return new WaitForSeconds(TrouverDialogueAvecTag(tag).DelaiTampon);

        ListeTampon.Remove(tag);
    }
}
