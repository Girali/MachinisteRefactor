using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Un_DicoDialogue : MonoBehaviour
{

    public Dictionary<int, Dialogue> Init()
    {
        Dictionary<int, Dialogue> DicoDialogue1 = new Dictionary<int, Dialogue>();

        Dialogue D100101 = new Dialogue();

        D100101.TexteDialogue = "Pour rappel, utilisez votre curseur pour saisir un objet dans la caisse, puis lâchez-le sur la gauche du tapis roulant.";

        D100101.DoiventEtreLu.Add(600112);

        D100101.Priorite = 6;

        D100101.NeDoitEtreLuQuUneFois = false;

        D100101.AucuneBriqueNestPose = true;

        DicoDialogue1.Add(100101, D100101);



        Dialogue D100201 = new Dialogue();

        D100201.TexteDialogue = "Pour la petite histoire, l'ennemi que vous disposez sur le tapis roulant depuis tout à l'heure s'appelle Harpagon.";

        D100201.TagDialogueSuivant = 400202;

        D100201.DoiventEtreLu.Add(600307);

        D100201.Priorite = 6;

        DicoDialogue1.Add(100201, D100201);



        Dialogue D100301 = new Dialogue();

        D100301.TexteDialogue = "J'y pense, mais pour revenir sur le sujet de l'équilibre entre l'ennui et la frustration des joueurs...";

        D100301.TagDialogueSuivant = 400302;

        D100301.DoiventEtreLu.Add(600405);

        D100301.Priorite = 6;

        DicoDialogue1.Add(100301, D100301);



        Dialogue D100401 = new Dialogue();

        D100401.TexteDialogue = "Vous savez, vous regarder travailler me met de la crème aux artères.";

        D100401.TagDialogueSuivant = 400402;

        D100401.DoiventEtreLu.Add(600405);

        D100401.Priorite = 6;

        DicoDialogue1.Add(100401, D100401);



        Dialogue D100601 = new Dialogue();

        D100601.TexteDialogue = "N'abusez pas trop des cassettes, faudrait pas que notre bon ami se transforme en Harpagon !";

        D100601.DoiventEtreLu.Add(602908);

        D100601.Priorite = 6;

        DicoDialogue1.Add(100601, D100601);



        Dialogue D100701 = new Dialogue();

        D100701.TexteDialogue = "À chaque péripétie sa cassette, les joueurs doivent être récompensés pour tous leurs coups d'éclat !";

        D100701.DoiventEtreLu.Add(602908);

        D100701.Priorite = 6;

        DicoDialogue1.Add(100701, D100701);



        Dialogue D100801 = new Dialogue();

        D100801.TexteDialogue = "La mise en scène est importante, c'est le vecteur de ce qu'on veut voir perpétuer.";

        D100801.TagDialogueSuivant = 400802;

        D100801.DoiventEtreLu.Add(603003);

        D100801.Priorite = 6;

        DicoDialogue1.Add(100801, D100801);



        Dialogue D100901 = new Dialogue();

        D100901.TexteDialogue = "Notre métier est difficile vous savez. Après les longues sessions de travail, j'ai qu'une envie c'est m'vautrer dans un fauteuil et lancer un vinyle de Radiohead.";

        D100901.TagDialogueSuivant = 400902;

        D100901.DoiventEtreLu.Add(100801);

        D100901.Priorite = 6;

        DicoDialogue1.Add(100901, D100901);



        Dialogue D101001 = new Dialogue();

        D101001.TexteDialogue = "Les gens du métier ont tendance à l'oublier, mais l'objectif de ce qu'on fait, ce n'est pas de rapporter de l'argent à ceux d'en haut.";

        D101001.TagDialogueSuivant = 401002;

        D101001.DoiventEtreLu.Add(602908);

        D101001.Priorite = 6;

        DicoDialogue1.Add(101001, D101001);



        Dialogue D101101 = new Dialogue();

        D101101.TexteDialogue = "C'est dommage, de là où on est, on n'arrive pas à apercevoir dans quelles conditions nos joueurs assistent à la pièce.";

        D101101.TagDialogueSuivant = 401102;

        D101101.DoiventEtreLu.Add(100801);

        D101101.Priorite = 6;

        DicoDialogue1.Add(101101, D101101);



        Dialogue D101201 = new Dialogue();

        D101201.TexteDialogue = "Je réfléchis à ces cassettes... J'les avais fabriqué pour les sortir après le lancement de la pièce. Pour relancer la dynamique vous voyez.";

        D101201.TagDialogueSuivant = 401202;

        D101201.DoiventEtreLu.Add(603003);

        D101201.Priorite = 6;

        DicoDialogue1.Add(101201, D101201);



        Dialogue D101501 = new Dialogue();

        D101501.TexteDialogue = "J'ai créé Arlequin après avoir lu un bouquin qui parlait de biais cognitifs.";

        D101501.TagDialogueSuivant = 401502;

        D101501.DoiventEtreLu.Add(303201);

        D101501.Priorite = 6;

        DicoDialogue1.Add(101501, D101501);



        Dialogue D101601 = new Dialogue();

        D101601.TexteDialogue = "Maitenant qu'vous pouvez poser votre brique où vous le voulez, faites bien attention à ce que vous faîtes !";

        D101601.TagDialogueSuivant = 401602;

        D101601.DoiventEtreLu.Add(303201);

        D101601.Priorite = 6;

        DicoDialogue1.Add(101601, D101601);

        return DicoDialogue1;
    }

    //private void Start()
    //{
    //    
    //    foreach (KeyValuePair<int, Dialogue> item in DicoDialogue1)
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
    //    //On peut enlever ce if si on a un son qui sapelle "NotDefined.wav" et qui dure 5s de silence, auquel cas on peut mettre la ligne directement et enelver la condition
    //    }
    //    
    //
    //    foreach (KeyValuePair<int, Dialogue> item in DicoDialogue1)
    //    {
    //        if (item.Value.TagDialogueSuivant != 0)
    //        {
    //            Quatre_DicoDialogue.DicoDialogue4[item.Value.TagDialogueSuivant].DelaiTampon = item.Value.TempsDialogue + item.Value.TempsPreDialogue + item.Value.TempsPostDialogue + 1;
    //        }
    //
    //
    //    }
    //
    //    if (DialogueManageur.DM.EnPlaytest)
    //    {
    //        foreach (KeyValuePair<int, Dialogue> item in DicoDialogue1)
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
