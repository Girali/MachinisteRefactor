using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deux_DicoDialogue : MonoBehaviour
{

    public Dictionary<int, Dialogue> Init()
    {
        Dictionary<int, Dialogue> DicoDialogue2 = new Dictionary<int, Dialogue>();

        Dialogue D200101 = new Dialogue();

        D200101.TexteDialogue = "J'ai failli oublier ! N'hésitez pas à frotter les briques sur le rideau avant de les déposer sur le tapis roulant.";

        D200101.TagDialogueSuivant = 500102;

        D200101.Priorite = 4;

        DicoDialogue2.Add(200101, D200101);



        Dialogue D200201 = new Dialogue();

        D200201.TexteDialogue = "Z'êtes sur d'avoir pris au serieux mon conseil de tout à l'heure ?";

        D200201.TagDialogueSuivant = 500202;

        D200201.DoiventEtreLu.Add(200101);

        D200201.Priorite = 4;

        D200201.NbDialogueSTNPMinimumDit = 5;

        DicoDialogue2.Add(200201, D200201);



        Dialogue D200301 = new Dialogue();

        D200301.TexteDialogue = "J'espère que vous êtes passioné par ce que vous faîtes, parce que dans le métier on a tendance à faire quelques heures sup'.";

        D200301.TagDialogueSuivant = 500302;

        D200301.Priorite = 4;

        DicoDialogue2.Add(200301, D200301);



        Dialogue D200401 = new Dialogue();

        D200401.TexteDialogue = "J'espère ne pas vous avoir effrayé tout à l'heure quand j'ai parlé d'heure sup'.";

        D200401.TagDialogueSuivant = 500402;

        D200401.DoiventEtreLu.Add(200301);

        D200401.NbDialogueSTNPMinimumDit = 5;

        D200401.Priorite = 4;

        DicoDialogue2.Add(200401, D200401);



        Dialogue D200501 = new Dialogue();

        D200501.TexteDialogue = "Ce matin j'étais tellement pressé de vous rencontrer que je me suis coupé en me rasant.";

        D200501.TagDialogueSuivant = 500502;

        D200501.Priorite = 4;

        DicoDialogue2.Add(200501, D200501);



        Dialogue D200601 = new Dialogue();

        D200601.TexteDialogue = "Ma balafre au visage me démange un peu, j'espère qu'elle ne vas pas s'infecter.";

        D200601.TagDialogueSuivant = 500602;

        D200601.DoiventEtreLu.Add(500502);

        D200601.NbDialogueSTNPMinimumDit = 5;

        D200601.Priorite = 4;

        DicoDialogue2.Add(200601, D200601);



        Dialogue D200701 = new Dialogue();

        D200701.TexteDialogue = "J'ai remarqué que vous êtes plus discret que bavard, je me trompe ?";

        D200701.TagDialogueSuivant = 500702;

        D200701.NbDialogueSTNPMinimumDit = 6;

        D200701.Priorite = 4;

        DicoDialogue2.Add(200701, D200701);



        Dialogue D200901 = new Dialogue();

        D200901.TexteDialogue = "On dirait qu'on a trouvé not' rythme de travail, z'en sortez comme un coq !";

        D200901.Priorite = 4;

        DicoDialogue2.Add(200901, D200901);



        Dialogue D201001 = new Dialogue();

        D201001.TexteDialogue = "Normalement, j'ai tout mis en oeuvre pour que cette pièce soit un succès total.";

        D201001.Priorite = 4;

        DicoDialogue2.Add(201001, D201001);



        Dialogue D201101 = new Dialogue();

        D201101.TexteDialogue = "C'est fou comme le silence a tendance à rappliquer rapidement.";

        D201101.NbDialogueSTNPMinimumDit = 7;

        D201101.Priorite = 4;

        DicoDialogue2.Add(201101, D201101);



        Dialogue D201201 = new Dialogue();

        D201201.TexteDialogue = "Au début, je voulais que nos places soient inversées. Vous auriez contrôlé le tapis roulant et rentranscrit les mouvements du joueur.";

        D201201.TagDialogueSuivant = 501202;

        D201201.Priorite = 4;

        DicoDialogue2.Add(201201, D201201);



        Dialogue D201401 = new Dialogue();

        D201401.TexteDialogue = "J'ai découvert une pièce fabuleuse ce matin sur mon téléphone.";

        D201401.TagDialogueSuivant = 501402;

        D201401.DoiventEtreLu.Add(100801);

        D201401.Priorite = 4;

        DicoDialogue2.Add(201401, D201401);



        Dialogue D201501 = new Dialogue();

        D201501.TexteDialogue = "Pour la pièce, j'avais aussi une autre idée de personnage... Un sale escroc profiteur, mais j'ai eu trop peur qu'il ne passe pas la censure.";

        D201501.DoiventEtreLu.Add(302901);

        D201501.Priorite = 4;

        DicoDialogue2.Add(201501, D201501);



        Dialogue D201601 = new Dialogue();

        D201601.TexteDialogue = "Et vous, z'avez un streameur que vous aimeriez attirer dans notre salle pour assister à la pièce ? ";

        D201601.DoiventEtreLu.Add(303201);

        D201601.TagDialogueSuivant = 501602;

        D201601.Priorite = 4;

        DicoDialogue2.Add(201601, D201601);



        Dialogue D201701 = new Dialogue();

        D201701.TexteDialogue = "Je me demande si le message des oeuvres infuse aussi bien quand on assiste à une pièce, que quand on assiste à sa version revisitée par un streameur.";

        D201701.DoiventEtreLu.Add(303201);

        D201701.Priorite = 4;

        DicoDialogue2.Add(201701, D201701);


        return DicoDialogue2;
    }


    //    private void Start()
    //{
    //
    //    foreach (KeyValuePair<int, Dialogue> item in DicoDialogue2)
    //    {
    //        item.Value.SonDialogue += item.Key.ToString();
    //
    //        int t = 0;
    //        FMOD.Studio.EventInstance instance;
    //        instance = FMODUnity.RuntimeManager.CreateInstance(item.Value.SonDialogue);
    //        FMOD.Studio.EventDescription description;
    //        //Prendre la durée du clip de item.Value.SonDialogue et le mettre dans item.Value.TempsDialogue
    //        instance.getDescription(out description);
    //        description.getLength(out t);
    //        item.Value.TempsDialogue = t / 1000;
    //        
    //
    //        //On peut enlever ce if si on a un son qui sapelle "NotDefined.wav" et qui dure 5s de silence, auquel cas on peut mettre la ligne directement et enelver la condition
    //    }
    //
    //
    //    foreach (KeyValuePair<int, Dialogue> item in DicoDialogue2)
    //    {
    //        if (item.Value.TagDialogueSuivant != 0)
    //        {
    //            Cinq_DicoDialogue.DicoDialogue5[item.Value.TagDialogueSuivant].DelaiTampon = item.Value.TempsDialogue + item.Value.TempsPreDialogue + item.Value.TempsPostDialogue + 1;
    //        }
    //
    //    }
    //
    //    if (DialogueManageur.Instance.EnPlaytest)
    //    {
    //        foreach (KeyValuePair<int, Dialogue> item in DicoDialogue2)
    //        {
    //            if (item.Value.SonDialogue == "event:/Test/")
    //            {
    //                item.Value.Desactive = true;
    //            }
    //        }
    //    }
    //    
    //}
}
