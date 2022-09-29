using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class Dialogue
{
    //INFO
    [TextArea]
    public string TexteDialogue = "None";
    //Le texte du dialogue

    public string SonDialogue = "event:/Test/";
    //Chemin d'acces Son du dialogue

    public float TempsDialogue = 5.0f;
    //Le temps que dure le dialogue (se met � jour selon la dur�e du fichier audio)

    public float TempsPreDialogue = 0.1f;
    //Temps de silence precedant le dialogue

    public float TempsPostDialogue = 0.36f;
    //Temps de silence apr�s le dialogue

    public bool AEteLu = false;
    //Indique si le dialogue a d�j� �t� lu

    public float DelaiTampon = 15.0f;
    //Le temps que le dialogue peut rester en tampon avant detre lu

    public int TagDialogueSuivant = 0;
    //Indique le dialogue qui doit etre lu apr�s celui ci

    public bool EvenementSpecial = false;
    //Indique si le lancement du dialogue doit declancher un evenement script�, et auquel cas le num�ro de l'evenement script�

    public int Priorite = 1;
    //Priorit� de lancement par rapport � d'autres dialogues si plusieurs dialogues sont dans le tampon



    //CONDITION (ATTENTION CA NEST UTILE QUE POUR LES DIALOGUES DU DICO 1 ET 2)

    public List<int> DoiventEtreLu = new List<int>();
    //Liste des dialogues qui doivent etre pour que le dialogue puisse etre selectionn�

    public bool Desactive = false;
    //Desactive un dialogue si true

    public bool NeDoitEtreLuQuUneFois = true;
    //Verifie si le dialogue a d�j� �t� lanc� et ne le lance pas si c'est le cas

    public bool AucuneBriqueNestPose = false;
    //Aucune brique n'est pos� depuis le debut

    public int NbDialogueSTNPMinimumDit = 0;

}

