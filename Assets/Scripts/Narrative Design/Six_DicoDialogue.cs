using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Six_DicoDialogue : MonoBehaviour
{
    public Dictionary<int, Dialogue> Init()
    {
        Dictionary<int, Dialogue> DicoDialogue6 = new Dictionary<int, Dialogue>();

        Dialogue D600102 = new Dialogue();

        D600102.TexteDialogue = "Z'êtes le stagiaire c'est ça ? J'ai appris récemment vot' venue.";

        D600102.Priorite = 9;

        D600102.TagDialogueSuivant = 600103;

        DicoDialogue6.Add(600102, D600102);




        Dialogue D600103 = new Dialogue();

        D600103.TexteDialogue = "Je n'ai pas eu le temps de faire le ménage, ceux d'en haut y z'ont l'chic pour prevenir au dernier moment.";

        D600103.Priorite = 9;

        D600103.TempsPostDialogue = 0.05f;

        D600103.TagDialogueSuivant = 600104;

        DicoDialogue6.Add(600103, D600103);



        Dialogue D600104 = new Dialogue();

        D600104.TexteDialogue = "C'est que... Ouh là mais on dirait que notre premier joueur vient d'arriver.";

        D600104.Priorite = 9;

        D600104.EvenementSpecial = true;

        D600104.TagDialogueSuivant = 600105;

        DicoDialogue6.Add(600104, D600104);



        Dialogue D600105 = new Dialogue();

        D600105.TexteDialogue = "Bon j'sais pas ce qu'on vous a dit en haut, mais notre métier c'est d'amuser ces joueurs.";

        D600105.Priorite = 9;

        D600105.TagDialogueSuivant = 600106;

        DicoDialogue6.Add(600105, D600105);


        
        Dialogue D600106 = new Dialogue();

        D600106.TexteDialogue = "Je sais que c'est vot' premier jour, donc j'vais essayer de vous la faire courte. Vous voyez ces caisses devant vous ?";

        D600106.Priorite = 9;

        D600106.TagDialogueSuivant = 600107;

        DicoDialogue6.Add(600106, D600106);



        Dialogue D600107 = new Dialogue();

        D600107.TexteDialogue = "Faudrait qu'vous en sortiez les accessoires et que vous les déposiez au démarrage du tapis roulant.";

        D600107.EvenementSpecial = true;

        D600107.Priorite = 9;

        D600107.TagDialogueSuivant = 600108;

        DicoDialogue6.Add(600107, D600107);



        Dialogue D600108 = new Dialogue();

        D600108.TexteDialogue = "Dans le jargon, on appelle ces accessoires des briques de gameplay.";

        D600108.Priorite = 9;

        D600108.TempsPostDialogue = 2;

        D600108.TagDialogueSuivant = 600109;

        DicoDialogue6.Add(600108, D600108);



        Dialogue D600109 = new Dialogue();

        D600109.TexteDialogue = "Ben allez-y n'ayez pas peur, prenez donc une brique et mettez là à gauche sur le tapis roulant. ";

        D600109.Priorite = 1;

        D600109.TagDialogueSuivant = 600110;

        D600109.TempsPostDialogue = 2;

        DicoDialogue6.Add(600109, D600109);



        Dialogue D600110 = new Dialogue();

        D600110.TexteDialogue = "Hum vous rencontrez des difficultés ?";

        D600110.Priorite = 1;

        D600110.TagDialogueSuivant = 600111;

        D600110.TempsPostDialogue = 2;

        DicoDialogue6.Add(600110, D600110);



        Dialogue D600111 = new Dialogue();

        D600111.TexteDialogue = "J'suis pas censé vous le dire, mais essayez peut-être d'utiliser votre curseur pour saisir les objets dans la caisse ?";

        D600111.Priorite = 1;

        D600111.TagDialogueSuivant = 600112;

        DicoDialogue6.Add(600111, D600111);



        Dialogue D600112 = new Dialogue();

        D600112.TexteDialogue = "Z'êtes là ?";

        D600112.TagDialogueSuivant = 600113;

        D600112.Priorite = 1;

        DicoDialogue6.Add(600112, D600112);



        Dialogue D600113 = new Dialogue();

        D600113.TexteDialogue = "J'peux attendre.";

        D600113.Priorite = 1;

        DicoDialogue6.Add(600113, D600113);



        Dialogue D600202 = new Dialogue();

        D600202.TexteDialogue = "Craignez rien en les manipulant, j'ai fabriqué chaque pièce moi-même. Elles sont toutes d'excellente facture !";

        D600202.TagDialogueSuivant = 600203;

        D600202.Priorite = 9;

        D600202.EvenementSpecial = true;

        DicoDialogue6.Add(600202, D600202);



        Dialogue D600203 = new Dialogue();

        D600203.TexteDialogue = "Ce que nos joueurs désirent, c'est que de ces briques, vous érigiez des niveaux rocambolesques.";

        D600203.TagDialogueSuivant = 600204;

        D600203.Priorite = 9;

        DicoDialogue6.Add(600203, D600203);



        Dialogue D600204 = new Dialogue();

        D600204.TexteDialogue = "N'hésitez pas à exploiter toute votre imagination !";

        D600204.TagDialogueSuivant = 600205;

        D600204.Priorite = 9;

        DicoDialogue6.Add(600204, D600204);



        Dialogue D600205 = new Dialogue();

        D600205.TexteDialogue = "D'ailleurs je... Enfin, je vous laisse découvrir tout ça. ";

        D600205.TagDialogueSuivant = 600206;

        D600205.Priorite = 9;

        DicoDialogue6.Add(600205, D600205);



        Dialogue D600206 = new Dialogue();

        D600206.TexteDialogue = "Essayez de garder un joueur assez intéréssé pour qu'il atteigne la fin du premier acte. ";

        D600206.TagDialogueSuivant = 600207;

        D600206.Priorite = 9;

        DicoDialogue6.Add(600206, D600206);



        Dialogue D600207 = new Dialogue();

        D600207.TexteDialogue = "Les actes se terminent quand les joueurs atteignent un grand drapeau, 'verrez qu'il fait son petit effet.";

        D600207.TagDialogueSuivant = 600208;

        D600207.Priorite = 9;

        DicoDialogue6.Add(600207, D600207);



        Dialogue D600208 = new Dialogue();

        D600208.TexteDialogue = "Allez je vous regarde. Z'allez parfaitement vous en sortir !";

        D600208.Priorite = 9;

        DicoDialogue6.Add(600208, D600208);



        Dialogue D600302 = new Dialogue();

        D600302.TexteDialogue = "Ça fait plaisir de voir la nouvelle génération avec autant d'aisance, on s'rassure sur l'avenir de notre profession.";

        D600302.TagDialogueSuivant = 600303;

        D600302.Priorite = 9;

        DicoDialogue6.Add(600302, D600302);



        Dialogue D600303 = new Dialogue();

        D600303.TexteDialogue = "Enfin ! On m'fera pas passer par la fenêtre tout de suite non plus ! Va falloir faire avec moi, partenaire.";

        D600303.TagDialogueSuivant = 600304;

        D600303.Priorite = 9;

        DicoDialogue6.Add(600303, D600303);



        Dialogue D600304 = new Dialogue();

        D600304.TexteDialogue = "J'imagine que vous l'avez remarqué, mais les joueurs ont tendance à rapidement s'ennuyer.";

        D600304.TagDialogueSuivant = 600305;

        D600304.Priorite = 9;

        DicoDialogue6.Add(600304, D600304);



        Dialogue D600305 = new Dialogue();

        D600305.TexteDialogue = "Faut arriver à les occuper en se réinventant et en proposant des mise en scène toujours plus ingénieuses.";

        D600305.TagDialogueSuivant = 600306;

        D600305.Priorite = 9;

        DicoDialogue6.Add(600305, D600305);



        Dialogue D600306 = new Dialogue();

        D600306.TexteDialogue = "Mais attention à n'pas le frustrer avec la difficulté. ";

        D600306.TagDialogueSuivant = 600307;

        D600306.Priorite = 9;

        DicoDialogue6.Add(600306, D600306);



        Dialogue D600307 = new Dialogue();

        D600307.TexteDialogue = "Trouver l'équilibre, c'est tous l'art de notre métier, je suis sur que vous allez vous en sortir !";

        D600307.TagDialogueSuivant = 600308;

        D600307.Priorite = 9;

        DicoDialogue6.Add(600307, D600307);




        Dialogue D600308 = new Dialogue();

        D600308.TexteDialogue = "J'vous l'ai pas dit plus tôt, mais si vous n'tenez pas la cadence, 'pouvez toujours arrêter le tapis pour prendre vot' temps.";

        D600308.TagDialogueSuivant = 600309;

        D600308.Priorite = 9;

        DicoDialogue6.Add(600308, D600308);



        Dialogue D600309 = new Dialogue();

        D600309.TexteDialogue = "Pointez votre curseur sur moi et je vous laisse l'espace nécessaire pour réfléchir. Mais n'en abusez pas au risque d'ennuyer les joueurs !";

        D600309.Priorite = 9;

        DicoDialogue6.Add(600309, D600309);



        Dialogue D600402 = new Dialogue();

        D600402.TexteDialogue = "C'est le deuxième joueur qui repart le sourire agraphé jusqu'au front.";

        D600402.TagDialogueSuivant = 600403;

        D600402.Priorite = 9;

        DicoDialogue6.Add(600402, D600402);



        Dialogue D600403 = new Dialogue();

        D600403.TexteDialogue = "Continuez, vous êtes... enfin, déjà, vous nous happez le public.";

        D600403.TagDialogueSuivant = 600404;

        D600403.Priorite = 9;

        DicoDialogue6.Add(600403, D600403);



        Dialogue D600404 = new Dialogue();

        D600404.TexteDialogue = "Avant vot' arrivée, nos joueurs n'étaient qu'des personnages qui exhumaient notre pièce par hasard.";

        D600404.TagDialogueSuivant = 600405;

        D600404.Priorite = 9;

        DicoDialogue6.Add(600404, D600404);



        Dialogue D600405 = new Dialogue();

        D600405.TexteDialogue = "Continuez ce que vous faites, et notre réussite s'accompagnera de... de récompenses !";

        D600405.Priorite = 9;

        DicoDialogue6.Add(600405, D600405);



        Dialogue D606802 = new Dialogue();

        D606802.TexteDialogue = "Mince je sais pas si vous m'entendez, mais le bouton 'Jouer' est cassé.";

        D606802.TempsPostDialogue = 0.7f;

        D606802.TagDialogueSuivant = 606803;

        D606802.Priorite = 9;

        DicoDialogue6.Add(606802, D606802);



        Dialogue D606803 = new Dialogue();

        D606803.TexteDialogue = "Je suis juste derrière le menu, faudrait que vous tiriez sur cette corde pour soulever l'écran qu'est en face de vous !";

        D606803.Priorite = 9;

        D606803.EvenementSpecial = true;

        DicoDialogue6.Add(606803, D606803);



        Dialogue D602902 = new Dialogue();

        D602902.TexteDialogue = "'Dirait bien que le bouche à oreille a marché, il y a des nouveaux arrivants qu'ont tous l'air d'aficionados de théatre.";

        D602902.TagDialogueSuivant = 602903;

        D602902.Priorite = 9;

        DicoDialogue6.Add(602902, D602902);



        Dialogue D602903 = new Dialogue();

        D602903.TexteDialogue = "Ça fait longtemps que j'attendais une opportunité comme celle-là, attendez d'voir c'que j'avais prévu.";

        D602903.TagDialogueSuivant = 602904;

        D602903.Priorite = 9;

        DicoDialogue6.Add(602903, D602903);



        Dialogue D602904 = new Dialogue();

        D602904.TexteDialogue = "Des nouvelles briques, en veux-tu, en voilà !";

        D602904.TagDialogueSuivant = 602905;

        D602904.EvenementSpecial = true;

        D602904.Priorite = 9;

        DicoDialogue6.Add(602904, D602904);



        Dialogue D602905 = new Dialogue();

        D602905.TexteDialogue = "Ça vas nous permettre de renouveler un peu notre mise en scène.";

        D602905.TagDialogueSuivant = 602906;

        D602905.Priorite = 9;

        DicoDialogue6.Add(602905, D602905);



        Dialogue D602906 = new Dialogue();

        D602906.TexteDialogue = "J'ai appelé c'te nouvelle brique une cassette.";

        D602906.TagDialogueSuivant = 602907;

        D602906.Priorite = 9;

        DicoDialogue6.Add(602906, D602906);



        Dialogue D602907 = new Dialogue();

        D602907.TexteDialogue = "Utilisez là pour récompenser les joueurs quand vous estimez qui z'ont relevé une belle péripétie.";

        D602907.TagDialogueSuivant = 602908;

        D602907.Priorite = 9;

        DicoDialogue6.Add(602907, D602907);



        Dialogue D602908 = new Dialogue();

        D602908.TexteDialogue = "Les v'là qui z'arrivent. N'oubliez pas, y sont déjà habitués au registre de notre pièce.";

        D602908.EvenementSpecial = true;

        D602908.TagDialogueSuivant = 602909;

        D602908.Priorite = 9;

        DicoDialogue6.Add(602908, D602908);



        Dialogue D602909 = new Dialogue();

        D602909.TexteDialogue = "C'coup là, montrez vous plus innovant que jamais ! Il faudrait que vous arriviez à leur faire finir le deuxième acte.";

        D602909.Priorite = 9;

        DicoDialogue6.Add(602909, D602909);



        Dialogue D603002 = new Dialogue();

        D603002.TexteDialogue = "Faîtes bien attention avec les cassettes, les joueurs doivent surtout pas reconnaitre les astuce de votre mise en scene et s'y habituer.";

        D603002.TagDialogueSuivant = 603003;

        D603002.Priorite = 9;

        DicoDialogue6.Add(603002, D603002);



        Dialogue D603003 = new Dialogue();

        D603003.TexteDialogue = "Une cassette, c'est quand ça surprend qu'ça fait plaisir !";

        D603003.Priorite = 9;

        DicoDialogue6.Add(603003, D603003);



        Dialogue D603102 = new Dialogue();

        D603102.TexteDialogue = "Hé dîtes, j'ai entendu dire que des streameurs hésiteraient d'venir assister à not' pièce.";

        D603102.TagDialogueSuivant = 603103;

        D603102.Priorite = 9;

        DicoDialogue6.Add(603102, D603102);



        Dialogue D603103 = new Dialogue();

        D603103.TexteDialogue = "Z'imaginez si on avait quelqu'un d'cet accabit comme audience ?";

        D603103.TagDialogueSuivant = 603104;

        D603103.Priorite = 9;

        DicoDialogue6.Add(603103, D603103);



        Dialogue D603104 = new Dialogue();

        D603104.TexteDialogue = "Avec toute l'influence qu'ont ces gens-là, vous et moi on partirait pour une tournée mondiale, pour sûr !";

        D603104.TagDialogueSuivant = 603105;

        D603104.Priorite = 9;

        DicoDialogue6.Add(603104, D603104);



        Dialogue D603105 = new Dialogue();

        D603105.TexteDialogue = "Mais avant ça, vas falloir attirer encore un chouïa plus d'attention sur nous.";

        D603105.TagDialogueSuivant = 603106;

        D603105.Priorite = 9;

        DicoDialogue6.Add(603105, D603105);



        Dialogue D603106 = new Dialogue();

        D603106.TexteDialogue = "Faîtes une mise en scène aguicheuse, astiquez les briques sur le rideau ! Faut que tout ceux qui s'approchent s'arrêtent pour assister à la pièce.";

        D603106.TagDialogueSuivant = 603107;

        D603106.Priorite = 9;

        DicoDialogue6.Add(603106, D603106);



        Dialogue D603107 = new Dialogue();

        D603107.TexteDialogue = "Faut qu'on leur donne envie d'assister à notre pièce, avant même qu'ils se posent la question de si ils en ont envie ou le temps.";

        D603107.TagDialogueSuivant = 603108;

        D603107.Priorite = 9;

        DicoDialogue6.Add(603107, D603107);



        Dialogue D603108 = new Dialogue();

        D603108.TexteDialogue = "On rentre dans la cours des grands et la concurence est rude, ne l'oublions pas. Il faut tout mettre en oeuvre pour attirer ses streameurs.";

        D603108.Priorite = 9;

        DicoDialogue6.Add(603108, D603108);



        Dialogue D603202 = new Dialogue();

        D603202.TexteDialogue = "Z'imaginez si un seul d'entre eux streamait le jeu jusqu'à la fin du 3eme acte ?";

        D603202.TagDialogueSuivant = 603203;

        D603202.Priorite = 9;

        DicoDialogue6.Add(603202, D603202);



        Dialogue D603203 = new Dialogue();

        D603203.TexteDialogue = "Not' pièce deviendrait immortelle et serait joué des siècles après not' mort.";

        D603203.TagDialogueSuivant = 603204;

        D603203.Priorite = 9;

        DicoDialogue6.Add(603203, D603203);



        Dialogue D603204 = new Dialogue();

        D603204.TexteDialogue = "Mmmh.. Il m'reste encore une nouvelle brique dans les coulisses qu'on pourrait ressortir. Arlequin que je l'ai appelé.";

        D603204.TagDialogueSuivant = 603205;

        D603204.Priorite = 9;

        DicoDialogue6.Add(603204, D603204);



        Dialogue D603205 = new Dialogue();

        D603205.TexteDialogue = "J'ai... J'ai longtemps hésité à l'integrer dans la pièce.";

        D603205.TagDialogueSuivant = 603206;

        D603205.Priorite = 9;

        DicoDialogue6.Add(603205, D603205);



        Dialogue D603206 = new Dialogue();

        D603206.TexteDialogue = "Dans l'idée, Arlequin donne des quêtes aux joueurs, des objectifs à suivre.";

        D603206.EvenementSpecial = true;

        D603206.TagDialogueSuivant = 603207;

        D603206.Priorite = 9;

        DicoDialogue6.Add(603206, D603206);



        Dialogue D603207 = new Dialogue();

        D603207.TexteDialogue = "Les joueurs se sentiront attirés par ces aventures. Ils auront envie de les suivre.";

        D603207.TagDialogueSuivant = 603208;

        D603207.Priorite = 9;

        DicoDialogue6.Add(603207, D603207);



        Dialogue D603208 = new Dialogue();

        D603208.TexteDialogue = "Ils se sentiront puissants si elle leur fait parcourir avec panache de périlleuses péripéties.";

        D603208.TagDialogueSuivant = 603209;

        D603208.Priorite = 9;

        DicoDialogue6.Add(603208, D603208);



        Dialogue D603209 = new Dialogue();

        D603209.TexteDialogue = "Pour vous aider, je vais aussi vous permettre plus de créativité, en vous laissant poser des briques où bon vous semble.";

        D603209.TagDialogueSuivant = 603210;

        D603209.EvenementSpecial = true;

        D603209.Priorite = 9;

        DicoDialogue6.Add(603209, D603209);



        Dialogue D603210 = new Dialogue();

        D603210.TexteDialogue = "Ça devrait doper votre imagination, et vous aider à garder un de nos amis streameurs jusqu'au 3eme acte.";

        D603210.TagDialogueSuivant = 603211;

        

        D603210.Priorite = 9;

        DicoDialogue6.Add(603210, D603210);



        Dialogue D603211 = new Dialogue();

        D603211.TexteDialogue = "Et voilà le premier qui arrive. Souvenez-vous, il nous suffit d'un seul streameur séduit et la pièce restera éternelle !";

        D603211.Priorite = 9;
        D603211.EvenementSpecial = true;

        DicoDialogue6.Add(603211, D603211);



        Dialogue D607202 = new Dialogue();

        D607202.TexteDialogue = "Il part... Il... Il vas surement allez uploader la capture de notre pièce sur sa chaîne Youtube ?";

        D607202.TagDialogueSuivant = 607203;

        D607202.Priorite = 9;

        DicoDialogue6.Add(607202, D607202);



        Dialogue D607203 = new Dialogue();

        D607203.TexteDialogue = "Je.. Euh...";

        D607203.TagDialogueSuivant = 607204;

        D607203.Priorite = 9;

        DicoDialogue6.Add(607203, D607203);



        Dialogue D607204 = new Dialogue();

        D607204.TexteDialogue = "C'est génial ! Bravo à nous ! Vous... Vous êtes content ?";

        D607204.TagDialogueSuivant = 607205;

        D607204.Priorite = 9;

        DicoDialogue6.Add(607204, D607204);



        Dialogue D607205 = new Dialogue();

        D607205.TexteDialogue = "Enfin enfin, il reste encore plein de choses à accomplir !";

        D607205.TagDialogueSuivant = 607206;

        D607205.Priorite = 9;

        DicoDialogue6.Add(607205, D607205);



        Dialogue D607206 = new Dialogue();

        D607206.TexteDialogue = "Je.. La prochaine étape c'est.. Hum... Attendez voir..";

        D607206.TagDialogueSuivant = 607207;

        D607206.Priorite = 9;

        DicoDialogue6.Add(607206, D607206);



        Dialogue D607207 = new Dialogue();

        D607207.TexteDialogue = "Coloniser l'Univers ! Nous allons maitenant étendre notre renommée jusqu'aux confins de la Voie Lactée !";

        D607207.TagDialogueSuivant = 607208;

        D607207.Priorite = 9;

        DicoDialogue6.Add(607207, D607207);



        Dialogue D607208 = new Dialogue();

        D607208.TexteDialogue = "Enfilez votre scaphandre l'ami, l'oeil de l'Univers nous apelle !";

        D607208.TagDialogueSuivant = 607209;

        D607208.Priorite = 9;

        DicoDialogue6.Add(607208, D607208);



        Dialogue D607209 = new Dialogue();

        D607209.TexteDialogue = "Haha.";

        D607209.TagDialogueSuivant = 607210;

        D607209.Priorite = 9;

        DicoDialogue6.Add(607209, D607209);



        Dialogue D607210 = new Dialogue();

        D607210.TexteDialogue = "Hmm.";

        D607210.TagDialogueSuivant = 607211;

        D607210.Priorite = 9;

        DicoDialogue6.Add(607210, D607210);



        Dialogue D607211 = new Dialogue();

        D607211.TexteDialogue = "Ça...Ça ne prend pas c'est ça ?";

        D607211.TagDialogueSuivant = 607302;

        D607211.Priorite = 9;

        DicoDialogue6.Add(607211, D607211);



        Dialogue D607302 = new Dialogue();

        D607302.TexteDialogue = "Je... J'imagine que ça s'arrête comme ça alors.";

        D607302.TagDialogueSuivant = 607303;

        D607302.Priorite = 9;

        DicoDialogue6.Add(607302, D607302);



        Dialogue D607303 = new Dialogue();

        D607303.TexteDialogue = "Je n'ai plus ni objectifs, ni récompense pour vous convaincre de continuer de jouer à ce jeu.";

        D607303.TagDialogueSuivant = 607304;

        D607303.Priorite = 9;

        DicoDialogue6.Add(607303, D607303);



        Dialogue D607304 = new Dialogue();

        D607304.TexteDialogue = "J'ai épuisé toute les astuces que je conaissais pour vous amuser et vous conserver jusqu'à ce moment.";

        D607304.TagDialogueSuivant = 607305;

        D607304.Priorite = 9;

        DicoDialogue6.Add(607304, D607304);



        Dialogue D607305 = new Dialogue();

        D607305.TexteDialogue = "Je... J'espere que vous avez quand même retenu un truc ou deux pendant ce jeu-vidéo.";

        D607305.TagDialogueSuivant = 607306;

        D607305.Priorite = 9;

        DicoDialogue6.Add(607305, D607305);



        Dialogue D607306 = new Dialogue();

        D607306.TexteDialogue = "Pour ma part je.. J'ai l'impression que j'aurai pu. J'aurai pu apprendre quelque chose. Que l'issu aurait pu être différente.";

        D607306.TagDialogueSuivant = 607307;

        D607306.Priorite = 9;

        DicoDialogue6.Add(607306, D607306);



        Dialogue D607307 = new Dialogue();

        D607307.TexteDialogue = "Mais j'ai écrit cette pièce, et je sais que c'est ainsi qu'elle doit se terminer.";

        D607307.TagDialogueSuivant = 607308;

        D607307.Priorite = 9;

        DicoDialogue6.Add(607307, D607307);



        Dialogue D607308 = new Dialogue();

        D607308.TexteDialogue = "Travailler avec vous a été... Au revoir, joueur dont j'ignore le nom.";

        D607308.TagDialogueSuivant = 607309;

        D607308.Priorite = 9;

        DicoDialogue6.Add(607308, D607308);



        Dialogue D607309 = new Dialogue();

        D607309.TexteDialogue = "Et c'est ainsi que cette pièce-ci s'est donc finie.";

        D607309.EvenementSpecial = true;

        D607309.Priorite = 9;

        DicoDialogue6.Add(607309, D607309);

        return DicoDialogue6;
    }

    //private void Start()
    //{
    //    
    //    foreach (KeyValuePair<int, Dialogue> item in DicoDialogue6)
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
    //    foreach (KeyValuePair<int, Dialogue> item in DicoDialogue6)
    //    {
    //        if (item.Value.TagDialogueSuivant != 0)
    //        {
    //            DicoDialogue6[item.Value.TagDialogueSuivant].DelaiTampon = item.Value.TempsDialogue + item.Value.TempsPreDialogue + item.Value.TempsPostDialogue + 1;
    //        }
    //
    //        
    //    }
    //}
}
