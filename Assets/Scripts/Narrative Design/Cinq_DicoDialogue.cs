using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cinq_DicoDialogue : MonoBehaviour
{
    public Dictionary<int, Dialogue> Init()
    {
        Dictionary<int, Dialogue> DicoDialogue5 = new Dictionary<int, Dialogue>();

        Dialogue D500102 = new Dialogue();

        D500102.TexteDialogue = "C'est une vieille superstition qu'on a dans le métier, ça construit un public plus ouvert !";

        D500102.Priorite = 5;

        DicoDialogue5.Add(500102, D500102);



        Dialogue D500202 = new Dialogue();

        D500202.TexteDialogue = "J'vous ai pas vu frotter beaucoup de briques sur le rideau jusqu'à maintenant.";

        D500202.TagDialogueSuivant = 500203;

        D500202.Priorite = 5;

        DicoDialogue5.Add(500202, D500202);



        Dialogue D500203 = new Dialogue();

        D500203.TexteDialogue = "Vous voulez attirer la malchance sur nous ?";

        D500203.Priorite = 5;

        DicoDialogue5.Add(500203, D500203);



        Dialogue D500302 = new Dialogue();

        D500302.TexteDialogue = "Rassurez-moi, vous pouvez enchainer des nuits de 4 heures de sommeil ?";

        D500302.Priorite = 5;

        DicoDialogue5.Add(500302, D500302);



        Dialogue D500402 = new Dialogue();

        D500402.TexteDialogue = "Si ça peut vous rassurer, on ne dépasse jamais les 70 heures par semaine.";

        D500402.TagDialogueSuivant = 500403;

        D500402.Priorite = 5;

        DicoDialogue5.Add(500402, D500402);



        Dialogue D500403 = new Dialogue();

        D500403.TexteDialogue = "Mais attention, c'est que du plaisir !";

        D500403.Priorite = 5;

        DicoDialogue5.Add(500403, D500403);



        Dialogue D500502 = new Dialogue();

        D500502.TexteDialogue = "Faut dire que je suis plus habitué à voir de nouvelles têtes. J'ai voulu me faire beau et j'y ai gagné qu'une balafre.";

        D500502.Priorite = 5;

        DicoDialogue5.Add(500502, D500502);



        Dialogue D500602 = new Dialogue();

        D500602.TexteDialogue = "Ce serait bête de mourir derrière la scène.";

        D500602.Priorite = 5;

        DicoDialogue5.Add(500602, D500602);



        Dialogue D500702 = new Dialogue();

        D500702.TexteDialogue = "";

        D500702.Priorite = 5;

        D500702.TagDialogueSuivant = 500703;

        DicoDialogue5.Add(500702, D500702);



        Dialogue D500703 = new Dialogue();

        D500703.TexteDialogue = "En tout cas pas de problème. Z'êtes libre d'être qui vous voulez avec moi.";

        D500703.Priorite = 5;

        DicoDialogue5.Add(500703, D500703);



        Dialogue D501202 = new Dialogue();

        D501202.TexteDialogue = "Mais finalement j'me suis dit que ce serait beaucoup moins amusant pour vous !";

        D501202.Priorite = 5;

        DicoDialogue5.Add(501202, D501202);



        Dialogue D501402 = new Dialogue();

        D501402.TexteDialogue = "Une pièce qui parlait de réussites et d'échecs, de conquête et de sacrifice.";

        D501402.TagDialogueSuivant = 501403;

        D501402.Priorite = 5;

        DicoDialogue5.Add(501402, D501402);



        Dialogue D501403 = new Dialogue();

        D501403.TexteDialogue = "L'ouverture était magnifique, dommage que la phase finale ferme ses rideaux sans nous laisser entrevoir son dénouement.";

        D501403.TagDialogueSuivant = 501404;

        D501403.Priorite = 5;

        DicoDialogue5.Add(501403, D501403);



        Dialogue D501404 = new Dialogue();

        D501404.TexteDialogue = "Les rois meurent comme nous, 'devrait pas y avoir de tabou à l'exposer sur une scène.";

        D501404.Priorite = 5;

        DicoDialogue5.Add(501404, D501404);



        Dialogue D501602 = new Dialogue();

        D501602.TexteDialogue = "'Seriez pas une fleur par hasard ?";

        D501602.TagDialogueSuivant = 501603;

        D501602.Priorite = 5;

        DicoDialogue5.Add(501602, D501602);



        Dialogue D501603 = new Dialogue();

        D501603.TexteDialogue = "En tout cas pour ma part, sachez que vous vous adressez à un membre de la PIRE comu.";

        D501603.TagDialogueSuivant = 501604;

        D501603.Priorite = 5;

        DicoDialogue5.Add(501603, D501603);



        Dialogue D501604 = new Dialogue();

        D501604.TexteDialogue = "COMBIEEEEEEEEEEEEEN ?";

        D501604.Priorite = 5;

        DicoDialogue5.Add(501604, D501604);

        return DicoDialogue5;
    }


    //    private void Start()
    //{
    //
    //    foreach (KeyValuePair<int, Dialogue> item in DicoDialogue5)
    //    {
    //        
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
    //        //On peut enlever ce if si on a un son qui sapelle "NotDefined.wav" et qui dure 5s de silence, auquel cas on peut mettre la ligne directement et enelver la condition
    //    }
    //
    //
    //    foreach (KeyValuePair<int, Dialogue> item in DicoDialogue5)
    //    {
    //        if (item.Value.TagDialogueSuivant != 0)
    //        {
    //            Cinq_DicoDialogue.DicoDialogue5[item.Value.TagDialogueSuivant].DelaiTampon = item.Value.TempsDialogue + item.Value.TempsPreDialogue + item.Value.TempsPostDialogue + 1;
    //        }
    //
    //    }
    //}
}
