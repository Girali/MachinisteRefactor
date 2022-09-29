using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quatre_DicoDialogue : MonoBehaviour
{

    public Dictionary<int, Dialogue> Init()
    {
        Dictionary<int, Dialogue> DicoDialogue4 = new Dictionary<int, Dialogue>();

        Dialogue D400202 = new Dialogue();

        D400202.TexteDialogue = "Je l'ai prénommé comme ça en réference au latin 'harpax'. Ça signifie 'Qui tire à soi'.";

        D400202.Priorite = 7;

        D400202.TagDialogueSuivant = 400203;

        DicoDialogue4.Add(400202, D400202);



        Dialogue D400203 = new Dialogue();

        D400203.TexteDialogue = "Je l'ai imaginé comme un vieillard riche et avare, obsédé par son argent.";

        D400203.Priorite = 7;

        D400203.TagDialogueSuivant = 400204;

        DicoDialogue4.Add(400203, D400203);



        Dialogue D400204 = new Dialogue();

        D400204.TexteDialogue = "Créer ces personnages, c'est un peu ma manière de transmettre mon oeil sur le globe, si v'voyez c'que je veux dire !";

        D400204.Priorite = 7;

        DicoDialogue4.Add(400204, D400204);



        Dialogue D400302 = new Dialogue();

        D400302.TexteDialogue = "Ça a un nom, c'est appelé la théorie du flow.";

        D400302.TagDialogueSuivant = 400303;

        D400302.Priorite = 7;

        DicoDialogue4.Add(400302, D400302);



        Dialogue D400303 = new Dialogue();

        D400303.TexteDialogue = "Un joueur est dans le flow quand il navigue entre l'ennui et la frustration.";

        D400303.TagDialogueSuivant = 400304;

        D400303.Priorite = 7;

        DicoDialogue4.Add(400303, D400303);



        Dialogue D400304 = new Dialogue();

        D400304.TexteDialogue = "Ça peut arriver dans plein de domaines : Le travail, le sport, ou ce qui nous intéresse : le théatre !";

        D400304.TagDialogueSuivant = 400305;

        D400304.Priorite = 7;

        DicoDialogue4.Add(400304, D400304);



        Dialogue D400305 = new Dialogue();

        D400305.TexteDialogue = "Dans cet état, les individus sont immergés dans leurs actions jusqu'à en perdre la notion du temps.";

        D400305.TagDialogueSuivant = 400306;

        D400305.Priorite = 7;

        DicoDialogue4.Add(400305, D400305);



        Dialogue D400306 = new Dialogue();

        D400306.TexteDialogue = "C'est exactement l'état dans lequel on veut plonger nos joueurs.";

        D400306.Priorite = 7;

        DicoDialogue4.Add(400306, D400306);



        Dialogue D400402 = new Dialogue();

        D400402.TexteDialogue = "Je me rend compte que j'aurai dû faire appel à quelqu'un pour m'aider il y a bien longtemps...";

        D400402.TagDialogueSuivant = 400403;

        D400402.Priorite = 7;

        DicoDialogue4.Add(400402, D400402);



        Dialogue D400403 = new Dialogue();

        D400403.TexteDialogue = "Tout ce temps de perdu...";

        D400403.TagDialogueSuivant = 400404;

        D400403.Priorite = 7;

        DicoDialogue4.Add(400403, D400403);



        Dialogue D400404 = new Dialogue();

        D400404.TexteDialogue = "M'enfin, ensemble on va le rattraper ! La pièce a encore le temps d'atteindre l'audience qu'elle mérite !";

        D400404.Priorite = 7;

        DicoDialogue4.Add(400404, D400404);



        Dialogue D400802 = new Dialogue();

        D400802.TexteDialogue = "Quand vous placez les briques, pensez à l'histoire que vous racontez.";

        D400802.TagDialogueSuivant = 400803;

        D400802.Priorite = 7;

        DicoDialogue4.Add(400802, D400802);



        Dialogue D400803 = new Dialogue();

        D400803.TexteDialogue = "C'est not' travail de faire passer des messages, des valeurs dans nos oeuvres.";

        D400803.TagDialogueSuivant = 400804;

        D400803.Priorite = 7;

        DicoDialogue4.Add(400803, D400803);



        Dialogue D400804 = new Dialogue();

        D400804.TexteDialogue = "Parfois un geste inattendu ou une tirade bien sentie, c'est c'qui fait comprendre toute la dimmension politique d'une oeuvre.";

        D400804.TagDialogueSuivant = 400805;

        D400804.Priorite = 7;

        DicoDialogue4.Add(400804, D400804);



        Dialogue D400805 = new Dialogue();

        D400805.TexteDialogue = "C'est important de garder tout ça en tête. En tout cas, moi c'est à ça qu'je pense tous les matins quand j'attends mon métro.";

        D400805.Priorite = 7;

        DicoDialogue4.Add(400805, D400805);



        Dialogue D400902 = new Dialogue();

        D400902.TexteDialogue = "Z'écoutez un peu de musique vous ? ";

        D400902.TagDialogueSuivant = 400903;

        D400902.Priorite = 7;

        DicoDialogue4.Add(400902, D400902);



        Dialogue D400903 = new Dialogue();

        D400903.TexteDialogue = "...";

        D400903.TagDialogueSuivant = 400904;

        D400903.Priorite = 7;

        DicoDialogue4.Add(400903, D400903);



        Dialogue D400904 = new Dialogue();

        D400904.TexteDialogue = "This dance... It's like a weapon... Of self defense... Self Defense...";

        D400904.TagDialogueSuivant = 400905;

        D400904.Priorite = 7;

        DicoDialogue4.Add(400904, D400904);



        Dialogue D400905 = new Dialogue();

        D400905.TexteDialogue = "Parfois j'écoute cette musique et je...";

        D400905.TagDialogueSuivant = 400906;

        D400905.Priorite = 7;

        DicoDialogue4.Add(400905, D400905);



        Dialogue D400906 = new Dialogue();

        D400906.TexteDialogue = "Enfin, ça rassure de garder un album qu'on chérit à portée d'oreilles.";

        D400906.Priorite = 7;

        DicoDialogue4.Add(400906, D400906);



        Dialogue D401002 = new Dialogue();

        D401002.TexteDialogue = "C'est de donner des armes à nos joueurs pour qu'ils comprennent le monde qui les entoure.";

        D401002.TagDialogueSuivant = 401003;

        D401002.Priorite = 7;

        DicoDialogue4.Add(401002, D401002);



        Dialogue D401003 = new Dialogue();

        D401003.TexteDialogue = "C'est pour cette raison qu'on mets tout en place, tout, pour qu'un maximum de joueurs voient notre pièce.";

        D401003.Priorite = 7;

        DicoDialogue4.Add(401003, D401003);



        Dialogue D401102 = new Dialogue();

        D401102.TexteDialogue = "Le contexte d'usage des joueurs conditionnent beaucoup leur capacité à comprendre le message des oeuvres auquels ils participent.";

        D401102.TagDialogueSuivant = 401103;

        D401102.Priorite = 7;

        DicoDialogue4.Add(401102, D401102);



        Dialogue D401103 = new Dialogue();

        D401103.TexteDialogue = "Et vous, vous êtes bien installé.e ?";  /// ? "Et vous, vous êtes bien installé·e ?"

        D401103.Priorite = 7;

        DicoDialogue4.Add(401103, D401103);



        Dialogue D401202 = new Dialogue();

        D401202.TexteDialogue = "Mais peut-être les revisiter dans la prochaine itération de la pièce? Avec du contenu aléatoire, qu'est ce que vous en pensez ?";

        D401202.TagDialogueSuivant = 401203;

        D401202.Priorite = 7;

        DicoDialogue4.Add(401202, D401202);



        Dialogue D401203 = new Dialogue();

        D401203.TexteDialogue = "Tantôt une cassette vide, tantôt une cassette pleine d'argent, tantôt une cassette de costumes.";

        D401203.TagDialogueSuivant = 401204;

        D401203.Priorite = 7;

        DicoDialogue4.Add(401203, D401203);



        Dialogue D401204 = new Dialogue();

        D401204.TexteDialogue = "Comme ça les joueurs pourraient developer une sorte d'addiction, et continuer à jouer tant qu'ils n'ont pas la cassettes qu'ils veulent ?";

        D401204.TagDialogueSuivant = 401205;

        D401204.Priorite = 7;

        DicoDialogue4.Add(401204, D401204);



        Dialogue D401205 = new Dialogue();

        D401205.TexteDialogue = "Mmmh... Je vais réfléchir à tout ça.";

        D401205.Priorite = 7;

        DicoDialogue4.Add(401205, D401205);



        Dialogue D401302 = new Dialogue();

        D401302.TexteDialogue = "Je ne suis si pas si lourd que j'en ai l'air.";

        D401302.Priorite = 1;

        DicoDialogue4.Add(401302, D401302);



        Dialogue D401502 = new Dialogue();

        D401502.TexteDialogue = "Ça expliquait que les individus ont du mal à s'arrêter au milieu d'une activité. À s'arrêter pendant une tâche non-accomplie.";

        D401502.TagDialogueSuivant = 401503;

        D401502.Priorite = 7;

        DicoDialogue4.Add(401502, D401502);



        Dialogue D401503 = new Dialogue();

        D401503.TexteDialogue = "Après ma lecture, je me suis tout de suite mis à la création de Arlequin. Un parfait moyen de garder nos joueurs un peu plus longtemps !";

        D401503.Priorite = 7;

        DicoDialogue4.Add(401503, D401503);



        Dialogue D401602 = new Dialogue();

        D401602.TexteDialogue = "S'agirait pas de m'en balacer une sur la tête !";

        D401602.Priorite = 7;

        DicoDialogue4.Add(401602, D401602);

        return DicoDialogue4;
    }



    //private void Start()
    //{
    //    
    //    foreach (KeyValuePair<int, Dialogue> item in DicoDialogue4)
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
    //    //On peut enlever ce if si on a un son qui sapelle "NotDefined.wav" et qui dure 5s de silence, auquel cas on peut mettre la ligne directement et enelver la condition
    //    }
    //    
    //
    //    foreach (KeyValuePair<int, Dialogue> item in DicoDialogue4)
    //    {
    //        if (item.Value.TagDialogueSuivant != 0)
    //        {
    //            Quatre_DicoDialogue.DicoDialogue4[item.Value.TagDialogueSuivant].DelaiTampon = item.Value.TempsDialogue + item.Value.TempsPreDialogue + item.Value.TempsPostDialogue + 1;
    //        }
    //
    //    }
    //}

}
