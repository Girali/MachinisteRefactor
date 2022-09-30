using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue/NewDialogue")]
public class DialogueObject : ScriptableObject
{
    public int ID;

    [TextArea]
    public string TexteDialogue = "None";
    //Le texte du dialogue

    public readonly string SonDialoguePath = "event:/Test/";
    public string SonDialogue = "event:/Test/";
    //Chemin d'acces Son du dialogue

    public float TempsDialogue = 5.0f;
    //Le temps que dure le dialogue (se met à jour selon la durée du fichier audio)

    public float TempsPreDialogue = 0.1f;
    //Temps de silence precedant le dialogue

    public float TempsPostDialogue = 0.36f;
    //Temps de silence après le dialogue

    public bool AEteLu = false;
    //Indique si le dialogue a déjà été lu

    public readonly float DelaiTamponConst = 15.0f;
    public float DelaiTampon = 15.0f;
    //Le temps que le dialogue peut rester en tampon avant detre lu

    [SerializeField]
    public DialogueObject TagDialogueSuivant = null;
    //Indique le dialogue qui doit etre lu après celui ci

    public bool EvenementSpecial = false;
    //Indique si le lancement du dialogue doit declancher un evenement scripté, et auquel cas le numéro de l'evenement scripté

    public int Priorite = 1;
    //Priorité de lancement par rapport à d'autres dialogues si plusieurs dialogues sont dans le tampon
    //CONDITION (ATTENTION CA NEST UTILE QUE POUR LES DIALOGUES DU DICO 1 ET 2)

    [SerializeField]
    public List<DialogueObject> DoiventEtreLu = new List<DialogueObject>();
    //Liste des dialogues qui doivent etre pour que le dialogue puisse etre selectionné

    public bool Desactive = false;
    //Desactive un dialogue si true

    public bool NeDoitEtreLuQuUneFois = true;
    //Verifie si le dialogue a déjà été lancé et ne le lance pas si c'est le cas

    public bool AucuneBriqueNestPose = false;
    //Aucune brique n'est posé depuis le debut

    public int NbDialogueSTNPMinimumDit = 0;

    public void Copy(Dialogues d)
    {
        this.TexteDialogue = d.TexteDialogue;
        this.SonDialogue = d.SonDialogue;
        this.TempsDialogue = d.TempsDialogue;
        this.TempsPreDialogue = d.TempsPreDialogue;
        this.TempsPostDialogue = d.TempsPostDialogue;
        this.AEteLu = d.AEteLu;
        this.DelaiTampon = d.DelaiTampon;
        this.EvenementSpecial = d.EvenementSpecial;
        this.Priorite = d.Priorite;
        this.Desactive = d.Desactive;
        this.NeDoitEtreLuQuUneFois = d.NeDoitEtreLuQuUneFois;
        this.AucuneBriqueNestPose = d.AucuneBriqueNestPose;
        this.NbDialogueSTNPMinimumDit = d.NbDialogueSTNPMinimumDit;
    }
}