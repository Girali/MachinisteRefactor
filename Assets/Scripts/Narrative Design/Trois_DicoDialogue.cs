using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trois_DicoDialogue : MonoBehaviour
{

    public Dictionary<int, Dialogues> Init()
    {
        Dictionary<int, Dialogues> DicoDialogue3 = new Dictionary<int, Dialogues>();

        Dialogues D300101 = new Dialogues();

        D300101.TexteDialogue = "Ah vous v'là ! Rentrez, rentrez ! Installez-vous par ici. Z'êtes bien en avance vous !";

        D300101.Priorite = 8;

        D300101.TagDialogueSuivant = 600102;

        D300101.TempsPreDialogue = 0.25f;

        DicoDialogue3.Add(300101, D300101);



        Dialogues D300201 = new Dialogues();

        D300201.TexteDialogue = "Bravo ! Les briques s'acheminent ensuite des coulisses vers la scène.";

        D300201.DelaiTampon = 20;

        D300201.Priorite = 8;

        D300201.TagDialogueSuivant = 600202;

        DicoDialogue3.Add(300201, D300201);



        Dialogues D300301 = new Dialogues();

        D300301.TexteDialogue = "Hé ben ! Vous l'avez immergé longtemps dans votre petit Univers ! Ah c'est qu'vous êtes né pour ce métier.";

        D300301.Priorite = 8;

        D300301.DelaiTampon = 30;

        D300301.TagDialogueSuivant = 600302;

        DicoDialogue3.Add(300301, D300301);



        Dialogues D300401 = new Dialogues();

        D300401.TexteDialogue = "Mais c'est qu'avec vous la pièce va s'construire une sacrée renommée !";

        D300401.DelaiTampon = 30;

        D300401.Priorite = 8;

        D300401.TagDialogueSuivant = 600402;

        DicoDialogue3.Add(300401, D300401);



        Dialogues D300501 = new Dialogues();

        D300501.TexteDialogue = "La hauteur lui va à ravir.";

        D300501.Priorite = 2;

        D300501.DelaiTampon = 1;

        DicoDialogue3.Add(300501, D300501);



        Dialogues D300601 = new Dialogues();

        D300601.TexteDialogue = "Grandiose, avec ces crapules les mauvaises herbes croissent toujours.";

        D300601.Priorite = 2;

        D300601.DelaiTampon = 1.5f;

        DicoDialogue3.Add(300601, D300601);



        Dialogues D300701 = new Dialogues();

        D300701.TexteDialogue = "Quand on a besoin des hommes, il faut bien s'adosser à eux.";

        D300701.Priorite = 2;

        D300701.DelaiTampon = 2.5f;

        DicoDialogue3.Add(300701, D300701);



        Dialogues D300801 = new Dialogues();

        D300801.TexteDialogue = "Hé bien hé bien ! Ils meurent ! Ils sont morts ! Ils sont enterrés !";

        D300801.Priorite = 2;

        D300801.DelaiTampon = 1.5f;

        DicoDialogue3.Add(300801, D300801);



        Dialogues D300901 = new Dialogues();

        D300901.TexteDialogue = "Quand il y a de la place pour un, il y en a bien pour dix.";

        D300901.Priorite = 2;

        D300901.DelaiTampon = 3;

        DicoDialogue3.Add(300901, D300901);



        Dialogues D301001 = new Dialogues();

        D301001.TexteDialogue = "Hé bien vous n'y allez pas de main morte vous.";

        D301001.Priorite = 2;

        D301001.DelaiTampon = 4;

        DicoDialogue3.Add(301001, D301001);



        Dialogues D301101 = new Dialogues();

        D301101.TexteDialogue = "L'amour est souvent le fruit du manque de place.";

        D301101.Priorite = 2;

        D301101.DelaiTampon = 1.5f;

        DicoDialogue3.Add(301101, D301101);



        Dialogues D301201 = new Dialogues();

        D301201.TexteDialogue = "Ça me rapelle ma première troupe de théatre.";

        D301201.Priorite = 2;

        D301201.DelaiTampon = 4;

        DicoDialogue3.Add(301201, D301201);



        Dialogues D301301 = new Dialogues();

        D301301.TexteDialogue = "Attention notre joueur commence à s'ennuyer.";

        D301301.Priorite = 4;

        D301301.DelaiTampon = 7;

        DicoDialogue3.Add(301301, D301301);



        Dialogues D301401 = new Dialogues();

        D301401.TexteDialogue = "On dirait que l'ennui coule le long d'ses narines.";

        D301401.Priorite = 4;

        D301401.DelaiTampon = 7;

        DicoDialogue3.Add(301401, D301401);



        Dialogues D301501 = new Dialogues();

        D301501.TexteDialogue = "Notre bon ami semble s'ennuyer.";

        D301501.Priorite = 4;

        D301501.DelaiTampon = 7;

        DicoDialogue3.Add(301501, D301501);



        Dialogues D301601 = new Dialogues();

        D301601.TexteDialogue = "Aïe j'ai bien peur qu'il ne meurre d'ennui.";

        D301601.Priorite = 4;

        D301601.DelaiTampon = 7;

        DicoDialogue3.Add(301601, D301601);



        Dialogues D301701 = new Dialogues();

        D301701.TexteDialogue = "Votre mise en scène est trop alambiquée !";

        D301701.Priorite = 4;

        D301701.DelaiTampon = 7;

        DicoDialogue3.Add(301701, D301701);



        Dialogues D301801 = new Dialogues();

        D301801.TexteDialogue = "Attention à bien mesurer les péripéties !";

        D301801.Priorite = 4;

        D301801.DelaiTampon = 7;

        DicoDialogue3.Add(301801, D301801);



        Dialogues D301901 = new Dialogues();

        D301901.TexteDialogue = "La pièce devient beaucoup trop compliqué.";

        D301901.Priorite = 4;

        D301901.DelaiTampon = 7;

        DicoDialogue3.Add(301901, D301901);



        Dialogues D302001 = new Dialogues();

        D302001.TexteDialogue = "Celui-là a eu l'air déçu de son experience...";

        D302001.Priorite = 4;

        D302001.DelaiTampon = 3;

        DicoDialogue3.Add(302001, D302001);



        Dialogues D302101 = new Dialogues();

        D302101.TexteDialogue = "Pas d'applaudissement, il est parti déçu.";

        D302101.Priorite = 4;

        D302101.DelaiTampon = 3;

        DicoDialogue3.Add(302101, D302101);



        Dialogues D302201 = new Dialogues();

        D302201.TexteDialogue = "Parti avant la fin du premier acte, il s'est pas pris au jeu de l'acteur.";

        D302201.Priorite = 4;

        D302201.DelaiTampon = 7;

        DicoDialogue3.Add(302201, D302201);



        Dialogues D302401 = new Dialogues();

        D302401.TexteDialogue = "La mort venue du ciel.";

        D302401.Priorite = 2;

        D302401.DelaiTampon = 1.5f;

        DicoDialogue3.Add(302401, D302401);



        Dialogues D302501 = new Dialogues();

        D302501.TexteDialogue = "Belle esquive !";

        D302501.Priorite = 2;

        D302501.DelaiTampon = 0.5f;

        DicoDialogue3.Add(302501, D302501);



        Dialogues D302601 = new Dialogues();

        D302601.TexteDialogue = "La scène a l'air inaccessible pour notre ami.";

        D302601.Priorite = 2;

        D302601.DelaiTampon = 7;

        DicoDialogue3.Add(302601, D302601);



        Dialogues D302701 = new Dialogues();

        D302701.TexteDialogue = "Notre joueur a du mal à suivre les rebondissements de la pièce";

        D302701.Priorite = 2;

        D302701.DelaiTampon = 7;

        DicoDialogue3.Add(302701, D302701);



        Dialogues D302901 = new Dialogues();

        D302901.TexteDialogue = "Extraordinaire ! Z'avez vraiment ça dans le sang.";

        D302901.Priorite = 8;

        D302901.TagDialogueSuivant = 602902;

        D302901.EvenementSpecial = true;

        DicoDialogue3.Add(302901, D302901);



        Dialogues D303001 = new Dialogues();

        D303001.TexteDialogue = "Z'avez pris le coup de main avec nos nouveaux joueurs, bravo !";

        D303001.Priorite = 8;

        D303001.TagDialogueSuivant = 603002;

        DicoDialogue3.Add(303001, D303001);



        Dialogues D303101 = new Dialogues();

        D303101.TexteDialogue = "Encore un d'comblé !";

        D303101.Priorite = 8;

        D303101.TagDialogueSuivant = 603102;

        DicoDialogue3.Add(303101, D303101);



        Dialogues D303201 = new Dialogues();

        D303201.TexteDialogue = "Ça y est on dirait bien qu'grace à vous, notre travail est devenu la pièce à streamer du moment.";

        D303201.Priorite = 8;

        D303201.EvenementSpecial = true;

        D303201.TagDialogueSuivant = 603202;

        DicoDialogue3.Add(303201, D303201);



        Dialogues D306801 = new Dialogues();

        D306801.TexteDialogue = "Ah y a quelqu'un ?";

        D306801.TempsPreDialogue = 0.8f;

        D306801.TempsPostDialogue = 1.05f;

        D306801.Priorite = 8;

        D306801.TagDialogueSuivant = 606802;

        DicoDialogue3.Add(306801, D306801);



        Dialogues D306901 = new Dialogues();

        D306901.TexteDialogue = "Le bouton 'Jouer' est cassé, faut que vous tiriez sur la corde avec votre curseur, pour parvenir jusqu'à moi !";

        D306901.DelaiTampon = 0.1f;

        D306901.Priorite = 8;

        DicoDialogue3.Add(306901, D306901);



        Dialogues D307201 = new Dialogues();

        D307201.TexteDialogue = "Ça... Ça y est il a terminé ?";

        D307201.TagDialogueSuivant = 607202;

        D307201.EvenementSpecial = true;

        D307201.Priorite = 8;

        DicoDialogue3.Add(307201, D307201);



        Dialogues D303601 = new Dialogues();

        D303601.TexteDialogue = "Premier acte, terminé !";

        D303601.Priorite = 4;

        DicoDialogue3.Add(303601, D303601);



        Dialogues D303701 = new Dialogues();

        D303701.TexteDialogue = "Et ainsi se conclut le premier acte.";

        D303701.Priorite = 4;

        DicoDialogue3.Add(303701, D303701);



        Dialogues D303801 = new Dialogues();

        D303801.TexteDialogue = "Fin du premier acte !";

        D303801.Priorite = 4;

        DicoDialogue3.Add(303801, D303801);



        Dialogues D303901 = new Dialogues();

        D303901.TexteDialogue = "On a pas vu le temps passer durant cet Acte 2 !";

        D303901.Priorite = 4;

        DicoDialogue3.Add(303901, D303901);



        Dialogues D304001 = new Dialogues();

        D304001.TexteDialogue = "Quel belle conclusion pour ce deuxième acte !";

        D304001.Priorite = 4;

        DicoDialogue3.Add(304001, D304001);



        Dialogues D304101 = new Dialogues();

        D304101.TexteDialogue = "Un acte 2 qui fût boulversant !";

        D304101.Priorite = 4;

        DicoDialogue3.Add(304101, D304101);



        Dialogues D304201 = new Dialogues();

        D304201.TexteDialogue = "Un troisième acte a coupé le souffle ! Le public est debout !";

        D304201.Priorite = 4;

        DicoDialogue3.Add(304201, D304201);



        Dialogues D304301 = new Dialogues();

        D304301.TexteDialogue = "C'est grandiose ! Mais quel 3eme acte saisissant !";

        D304301.Priorite = 4;

        DicoDialogue3.Add(304301, D304301);



        Dialogues D304401 = new Dialogues();

        D304401.TexteDialogue = "Ce 3eme acte, c'était... Vous apprenez vite.";

        D304401.Priorite = 4;

        DicoDialogue3.Add(304401, D304401);



        return DicoDialogue3;
    }

    //private void Start()
    //{
    //    Dico6 = GetComponent<Six_DicoDialogue>();
    //    foreach (KeyValuePair<int, Dialogues> item in DicoDialogue3)
    //    {
    //        
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
    //    foreach (KeyValuePair<int, Dialogues> item in DicoDialogue3)
    //    {
    //        if (item.Value.TagDialogueSuivant != 0)
    //        {
    //            Dico6.DicoDialogue6[item.Value.TagDialogueSuivant].DelaiTampon = item.Value.TempsDialogue + item.Value.TempsPreDialogue + item.Value.TempsPostDialogue + 1;
    //        }
    //
    //    }
    //}

}
