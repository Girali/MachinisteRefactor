using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Six_DicoDialogue : MonoBehaviour
{
    public Dictionary<int, Dialogues> Init()
    {
        Dictionary<int, Dialogues> DicoDialogue6 = new Dictionary<int, Dialogues>();

        Dialogues D600102 = new Dialogues();

        D600102.TexteDialogue = "Z'�tes le stagiaire c'est �a ? J'ai appris r�cemment vot' venue.";

        D600102.Priorite = 9;

        D600102.TagDialogueSuivant = 600103;

        DicoDialogue6.Add(600102, D600102);




        Dialogues D600103 = new Dialogues();

        D600103.TexteDialogue = "Je n'ai pas eu le temps de faire le m�nage, ceux d'en haut y z'ont l'chic pour prevenir au dernier moment.";

        D600103.Priorite = 9;

        D600103.TempsPostDialogue = 0.05f;

        D600103.TagDialogueSuivant = 600104;

        DicoDialogue6.Add(600103, D600103);



        Dialogues D600104 = new Dialogues();

        D600104.TexteDialogue = "C'est que... Ouh l� mais on dirait que notre premier joueur vient d'arriver.";

        D600104.Priorite = 9;

        D600104.EvenementSpecial = true;

        D600104.TagDialogueSuivant = 600105;

        DicoDialogue6.Add(600104, D600104);



        Dialogues D600105 = new Dialogues();

        D600105.TexteDialogue = "Bon j'sais pas ce qu'on vous a dit en haut, mais notre m�tier c'est d'amuser ces joueurs.";

        D600105.Priorite = 9;

        D600105.TagDialogueSuivant = 600106;

        DicoDialogue6.Add(600105, D600105);


        
        Dialogues D600106 = new Dialogues();

        D600106.TexteDialogue = "Je sais que c'est vot' premier jour, donc j'vais essayer de vous la faire courte. Vous voyez ces caisses devant vous ?";

        D600106.Priorite = 9;

        D600106.TagDialogueSuivant = 600107;

        DicoDialogue6.Add(600106, D600106);



        Dialogues D600107 = new Dialogues();

        D600107.TexteDialogue = "Faudrait qu'vous en sortiez les accessoires et que vous les d�posiez au d�marrage du tapis roulant.";

        D600107.EvenementSpecial = true;

        D600107.Priorite = 9;

        D600107.TagDialogueSuivant = 600108;

        DicoDialogue6.Add(600107, D600107);



        Dialogues D600108 = new Dialogues();

        D600108.TexteDialogue = "Dans le jargon, on appelle ces accessoires des briques de gameplay.";

        D600108.Priorite = 9;

        D600108.TempsPostDialogue = 2;

        D600108.TagDialogueSuivant = 600109;

        DicoDialogue6.Add(600108, D600108);



        Dialogues D600109 = new Dialogues();

        D600109.TexteDialogue = "Ben allez-y n'ayez pas peur, prenez donc une brique et mettez l� � gauche sur le tapis roulant. ";

        D600109.Priorite = 1;

        D600109.TagDialogueSuivant = 600110;

        D600109.TempsPostDialogue = 2;

        DicoDialogue6.Add(600109, D600109);



        Dialogues D600110 = new Dialogues();

        D600110.TexteDialogue = "Hum vous rencontrez des difficult�s ?";

        D600110.Priorite = 1;

        D600110.TagDialogueSuivant = 600111;

        D600110.TempsPostDialogue = 2;

        DicoDialogue6.Add(600110, D600110);



        Dialogues D600111 = new Dialogues();

        D600111.TexteDialogue = "J'suis pas cens� vous le dire, mais essayez peut-�tre d'utiliser votre curseur pour saisir les objets dans la caisse ?";

        D600111.Priorite = 1;

        D600111.TagDialogueSuivant = 600112;

        DicoDialogue6.Add(600111, D600111);



        Dialogues D600112 = new Dialogues();

        D600112.TexteDialogue = "Z'�tes l� ?";

        D600112.TagDialogueSuivant = 600113;

        D600112.Priorite = 1;

        DicoDialogue6.Add(600112, D600112);



        Dialogues D600113 = new Dialogues();

        D600113.TexteDialogue = "J'peux attendre.";

        D600113.Priorite = 1;

        DicoDialogue6.Add(600113, D600113);



        Dialogues D600202 = new Dialogues();

        D600202.TexteDialogue = "Craignez rien en les manipulant, j'ai fabriqu� chaque pi�ce moi-m�me. Elles sont toutes d'excellente facture !";

        D600202.TagDialogueSuivant = 600203;

        D600202.Priorite = 9;

        D600202.EvenementSpecial = true;

        DicoDialogue6.Add(600202, D600202);



        Dialogues D600203 = new Dialogues();

        D600203.TexteDialogue = "Ce que nos joueurs d�sirent, c'est que de ces briques, vous �rigiez des niveaux rocambolesques.";

        D600203.TagDialogueSuivant = 600204;

        D600203.Priorite = 9;

        DicoDialogue6.Add(600203, D600203);



        Dialogues D600204 = new Dialogues();

        D600204.TexteDialogue = "N'h�sitez pas � exploiter toute votre imagination !";

        D600204.TagDialogueSuivant = 600205;

        D600204.Priorite = 9;

        DicoDialogue6.Add(600204, D600204);



        Dialogues D600205 = new Dialogues();

        D600205.TexteDialogue = "D'ailleurs je... Enfin, je vous laisse d�couvrir tout �a. ";

        D600205.TagDialogueSuivant = 600206;

        D600205.Priorite = 9;

        DicoDialogue6.Add(600205, D600205);



        Dialogues D600206 = new Dialogues();

        D600206.TexteDialogue = "Essayez de garder un joueur assez int�r�ss� pour qu'il atteigne la fin du premier acte. ";

        D600206.TagDialogueSuivant = 600207;

        D600206.Priorite = 9;

        DicoDialogue6.Add(600206, D600206);



        Dialogues D600207 = new Dialogues();

        D600207.TexteDialogue = "Les actes se terminent quand les joueurs atteignent un grand drapeau, 'verrez qu'il fait son petit effet.";

        D600207.TagDialogueSuivant = 600208;

        D600207.Priorite = 9;

        DicoDialogue6.Add(600207, D600207);



        Dialogues D600208 = new Dialogues();

        D600208.TexteDialogue = "Allez je vous regarde. Z'allez parfaitement vous en sortir !";

        D600208.Priorite = 9;

        D600208.EvenementSpecial = true;

        DicoDialogue6.Add(600208, D600208);



        Dialogues D600302 = new Dialogues();

        D600302.TexteDialogue = "�a fait plaisir de voir la nouvelle g�n�ration avec autant d'aisance, on s'rassure sur l'avenir de notre profession.";

        D600302.TagDialogueSuivant = 600303;

        D600302.Priorite = 9;

        DicoDialogue6.Add(600302, D600302);



        Dialogues D600303 = new Dialogues();

        D600303.TexteDialogue = "Enfin ! On m'fera pas passer par la fen�tre tout de suite non plus ! Va falloir faire avec moi, partenaire.";

        D600303.TagDialogueSuivant = 600304;

        D600303.Priorite = 9;

        DicoDialogue6.Add(600303, D600303);



        Dialogues D600304 = new Dialogues();

        D600304.TexteDialogue = "J'imagine que vous l'avez remarqu�, mais les joueurs ont tendance � rapidement s'ennuyer.";

        D600304.TagDialogueSuivant = 600305;

        D600304.Priorite = 9;

        DicoDialogue6.Add(600304, D600304);



        Dialogues D600305 = new Dialogues();

        D600305.TexteDialogue = "Faut arriver � les occuper en se r�inventant et en proposant des mise en sc�ne toujours plus ing�nieuses.";

        D600305.TagDialogueSuivant = 600306;

        D600305.Priorite = 9;

        DicoDialogue6.Add(600305, D600305);



        Dialogues D600306 = new Dialogues();

        D600306.TexteDialogue = "Mais attention � n'pas le frustrer avec la difficult�. ";

        D600306.TagDialogueSuivant = 600307;

        D600306.Priorite = 9;

        DicoDialogue6.Add(600306, D600306);



        Dialogues D600307 = new Dialogues();

        D600307.TexteDialogue = "Trouver l'�quilibre, c'est tous l'art de notre m�tier, je suis sur que vous allez vous en sortir !";

        D600307.TagDialogueSuivant = 600308;

        D600307.Priorite = 9;

        DicoDialogue6.Add(600307, D600307);




        Dialogues D600308 = new Dialogues();

        D600308.TexteDialogue = "J'vous l'ai pas dit plus t�t, mais si vous n'tenez pas la cadence, 'pouvez toujours arr�ter le tapis pour prendre vot' temps.";

        D600308.TagDialogueSuivant = 600309;

        D600308.Priorite = 9;

        DicoDialogue6.Add(600308, D600308);



        Dialogues D600309 = new Dialogues();

        D600309.TexteDialogue = "Pointez votre curseur sur moi et je vous laisse l'espace n�cessaire pour r�fl�chir. Mais n'en abusez pas au risque d'ennuyer les joueurs !";

        D600309.Priorite = 9;

        DicoDialogue6.Add(600309, D600309);



        Dialogues D600402 = new Dialogues();

        D600402.TexteDialogue = "C'est le deuxi�me joueur qui repart le sourire agraph� jusqu'au front.";

        D600402.TagDialogueSuivant = 600403;

        D600402.Priorite = 9;

        DicoDialogue6.Add(600402, D600402);



        Dialogues D600403 = new Dialogues();

        D600403.TexteDialogue = "Continuez, vous �tes... enfin, d�j�, vous nous happez le public.";

        D600403.TagDialogueSuivant = 600404;

        D600403.Priorite = 9;

        DicoDialogue6.Add(600403, D600403);



        Dialogues D600404 = new Dialogues();

        D600404.TexteDialogue = "Avant vot' arriv�e, nos joueurs n'�taient qu'des personnages qui exhumaient notre pi�ce par hasard.";

        D600404.TagDialogueSuivant = 600405;

        D600404.Priorite = 9;

        DicoDialogue6.Add(600404, D600404);



        Dialogues D600405 = new Dialogues();

        D600405.TexteDialogue = "Continuez ce que vous faites, et notre r�ussite s'accompagnera de... de r�compenses !";

        D600405.Priorite = 9;

        DicoDialogue6.Add(600405, D600405);



        Dialogues D606802 = new Dialogues();

        D606802.TexteDialogue = "Mince je sais pas si vous m'entendez, mais le bouton 'Jouer' est cass�.";

        D606802.TempsPostDialogue = 0.7f;

        D606802.TagDialogueSuivant = 606803;

        D606802.Priorite = 9;

        DicoDialogue6.Add(606802, D606802);



        Dialogues D606803 = new Dialogues();

        D606803.TexteDialogue = "Je suis juste derri�re le menu, faudrait que vous tiriez sur cette corde pour soulever l'�cran qu'est en face de vous !";

        D606803.Priorite = 9;

        D606803.EvenementSpecial = true;

        DicoDialogue6.Add(606803, D606803);



        Dialogues D602902 = new Dialogues();

        D602902.TexteDialogue = "'Dirait bien que le bouche � oreille a march�, il y a des nouveaux arrivants qu'ont tous l'air d'aficionados de th�atre.";

        D602902.TagDialogueSuivant = 602903;

        D602902.Priorite = 9;

        DicoDialogue6.Add(602902, D602902);



        Dialogues D602903 = new Dialogues();

        D602903.TexteDialogue = "�a fait longtemps que j'attendais une opportunit� comme celle-l�, attendez d'voir c'que j'avais pr�vu.";

        D602903.TagDialogueSuivant = 602904;

        D602903.Priorite = 9;

        DicoDialogue6.Add(602903, D602903);



        Dialogues D602904 = new Dialogues();

        D602904.TexteDialogue = "Des nouvelles briques, en veux-tu, en voil� !";

        D602904.TagDialogueSuivant = 602905;

        D602904.EvenementSpecial = true;

        D602904.Priorite = 9;

        DicoDialogue6.Add(602904, D602904);



        Dialogues D602905 = new Dialogues();

        D602905.TexteDialogue = "�a vas nous permettre de renouveler un peu notre mise en sc�ne.";

        D602905.TagDialogueSuivant = 602906;

        D602905.Priorite = 9;

        DicoDialogue6.Add(602905, D602905);



        Dialogues D602906 = new Dialogues();

        D602906.TexteDialogue = "J'ai appel� c'te nouvelle brique une cassette.";

        D602906.TagDialogueSuivant = 602907;

        D602906.Priorite = 9;

        DicoDialogue6.Add(602906, D602906);



        Dialogues D602907 = new Dialogues();

        D602907.TexteDialogue = "Utilisez l� pour r�compenser les joueurs quand vous estimez qui z'ont relev� une belle p�rip�tie.";

        D602907.TagDialogueSuivant = 602908;

        D602907.Priorite = 9;

        DicoDialogue6.Add(602907, D602907);



        Dialogues D602908 = new Dialogues();

        D602908.TexteDialogue = "Les v'l� qui z'arrivent. N'oubliez pas, y sont d�j� habitu�s au registre de notre pi�ce.";

        D602908.EvenementSpecial = true;

        D602908.TagDialogueSuivant = 602909;

        D602908.Priorite = 9;

        DicoDialogue6.Add(602908, D602908);



        Dialogues D602909 = new Dialogues();

        D602909.TexteDialogue = "C'coup l�, montrez vous plus innovant que jamais ! Il faudrait que vous arriviez � leur faire finir le deuxi�me acte.";

        D602909.Priorite = 9;

        DicoDialogue6.Add(602909, D602909);



        Dialogues D603002 = new Dialogues();

        D603002.TexteDialogue = "Fa�tes bien attention avec les cassettes, les joueurs doivent surtout pas reconnaitre les astuce de votre mise en scene et s'y habituer.";

        D603002.TagDialogueSuivant = 603003;

        D603002.Priorite = 9;

        DicoDialogue6.Add(603002, D603002);



        Dialogues D603003 = new Dialogues();

        D603003.TexteDialogue = "Une cassette, c'est quand �a surprend qu'�a fait plaisir !";

        D603003.Priorite = 9;

        DicoDialogue6.Add(603003, D603003);



        Dialogues D603102 = new Dialogues();

        D603102.TexteDialogue = "H� d�tes, j'ai entendu dire que des streameurs h�siteraient d'venir assister � not' pi�ce.";

        D603102.TagDialogueSuivant = 603103;

        D603102.Priorite = 9;

        DicoDialogue6.Add(603102, D603102);



        Dialogues D603103 = new Dialogues();

        D603103.TexteDialogue = "Z'imaginez si on avait quelqu'un d'cet accabit comme audience ?";

        D603103.TagDialogueSuivant = 603104;

        D603103.Priorite = 9;

        DicoDialogue6.Add(603103, D603103);



        Dialogues D603104 = new Dialogues();

        D603104.TexteDialogue = "Avec toute l'influence qu'ont ces gens-l�, vous et moi on partirait pour une tourn�e mondiale, pour s�r !";

        D603104.TagDialogueSuivant = 603105;

        D603104.Priorite = 9;

        DicoDialogue6.Add(603104, D603104);



        Dialogues D603105 = new Dialogues();

        D603105.TexteDialogue = "Mais avant �a, vas falloir attirer encore un chou�a plus d'attention sur nous.";

        D603105.TagDialogueSuivant = 603106;

        D603105.Priorite = 9;

        DicoDialogue6.Add(603105, D603105);



        Dialogues D603106 = new Dialogues();

        D603106.TexteDialogue = "Fa�tes une mise en sc�ne aguicheuse, astiquez les briques sur le rideau ! Faut que tout ceux qui s'approchent s'arr�tent pour assister � la pi�ce.";

        D603106.TagDialogueSuivant = 603107;

        D603106.Priorite = 9;

        DicoDialogue6.Add(603106, D603106);



        Dialogues D603107 = new Dialogues();

        D603107.TexteDialogue = "Faut qu'on leur donne envie d'assister � notre pi�ce, avant m�me qu'ils se posent la question de si ils en ont envie ou le temps.";

        D603107.TagDialogueSuivant = 603108;

        D603107.Priorite = 9;

        DicoDialogue6.Add(603107, D603107);



        Dialogues D603108 = new Dialogues();

        D603108.TexteDialogue = "On rentre dans la cours des grands et la concurence est rude, ne l'oublions pas. Il faut tout mettre en oeuvre pour attirer ses streameurs.";

        D603108.Priorite = 9;

        DicoDialogue6.Add(603108, D603108);



        Dialogues D603202 = new Dialogues();

        D603202.TexteDialogue = "Z'imaginez si un seul d'entre eux streamait le jeu jusqu'� la fin du 3eme acte ?";

        D603202.TagDialogueSuivant = 603203;

        D603202.Priorite = 9;

        DicoDialogue6.Add(603202, D603202);



        Dialogues D603203 = new Dialogues();

        D603203.TexteDialogue = "Not' pi�ce deviendrait immortelle et serait jou� des si�cles apr�s not' mort.";

        D603203.TagDialogueSuivant = 603204;

        D603203.Priorite = 9;

        DicoDialogue6.Add(603203, D603203);



        Dialogues D603204 = new Dialogues();

        D603204.TexteDialogue = "Mmmh.. Il m'reste encore une nouvelle brique dans les coulisses qu'on pourrait ressortir. Arlequin que je l'ai appel�.";

        D603204.TagDialogueSuivant = 603205;

        D603204.Priorite = 9;

        DicoDialogue6.Add(603204, D603204);



        Dialogues D603205 = new Dialogues();

        D603205.TexteDialogue = "J'ai... J'ai longtemps h�sit� � l'integrer dans la pi�ce.";

        D603205.TagDialogueSuivant = 603206;

        D603205.Priorite = 9;

        DicoDialogue6.Add(603205, D603205);



        Dialogues D603206 = new Dialogues();

        D603206.TexteDialogue = "Dans l'id�e, Arlequin donne des qu�tes aux joueurs, des objectifs � suivre.";

        D603206.EvenementSpecial = true;

        D603206.TagDialogueSuivant = 603207;

        D603206.Priorite = 9;

        DicoDialogue6.Add(603206, D603206);



        Dialogues D603207 = new Dialogues();

        D603207.TexteDialogue = "Les joueurs se sentiront attir�s par ces aventures. Ils auront envie de les suivre.";

        D603207.TagDialogueSuivant = 603208;

        D603207.Priorite = 9;

        DicoDialogue6.Add(603207, D603207);



        Dialogues D603208 = new Dialogues();

        D603208.TexteDialogue = "Ils se sentiront puissants si elle leur fait parcourir avec panache de p�rilleuses p�rip�ties.";

        D603208.TagDialogueSuivant = 603209;

        D603208.Priorite = 9;

        DicoDialogue6.Add(603208, D603208);



        Dialogues D603209 = new Dialogues();

        D603209.TexteDialogue = "Pour vous aider, je vais aussi vous permettre plus de cr�ativit�, en vous laissant poser des briques o� bon vous semble.";

        D603209.TagDialogueSuivant = 603210;

        D603209.EvenementSpecial = true;

        D603209.Priorite = 9;

        DicoDialogue6.Add(603209, D603209);



        Dialogues D603210 = new Dialogues();

        D603210.TexteDialogue = "�a devrait doper votre imagination, et vous aider � garder un de nos amis streameurs jusqu'au 3eme acte.";

        D603210.TagDialogueSuivant = 603211;

        

        D603210.Priorite = 9;

        DicoDialogue6.Add(603210, D603210);



        Dialogues D603211 = new Dialogues();

        D603211.TexteDialogue = "Et voil� le premier qui arrive. Souvenez-vous, il nous suffit d'un seul streameur s�duit et la pi�ce restera �ternelle !";

        D603211.Priorite = 9;
        D603211.EvenementSpecial = true;

        DicoDialogue6.Add(603211, D603211);



        Dialogues D607202 = new Dialogues();

        D607202.TexteDialogue = "Il part... Il... Il vas surement allez uploader la capture de notre pi�ce sur sa cha�ne Youtube ?";

        D607202.TagDialogueSuivant = 607203;

        D607202.Priorite = 9;

        DicoDialogue6.Add(607202, D607202);



        Dialogues D607203 = new Dialogues();

        D607203.TexteDialogue = "Je.. Euh...";

        D607203.TagDialogueSuivant = 607204;

        D607203.Priorite = 9;

        DicoDialogue6.Add(607203, D607203);



        Dialogues D607204 = new Dialogues();

        D607204.TexteDialogue = "C'est g�nial ! Bravo � nous ! Vous... Vous �tes content ?";

        D607204.TagDialogueSuivant = 607205;

        D607204.Priorite = 9;

        DicoDialogue6.Add(607204, D607204);



        Dialogues D607205 = new Dialogues();

        D607205.TexteDialogue = "Enfin enfin, il reste encore plein de choses � accomplir !";

        D607205.TagDialogueSuivant = 607206;

        D607205.Priorite = 9;

        DicoDialogue6.Add(607205, D607205);



        Dialogues D607206 = new Dialogues();

        D607206.TexteDialogue = "Je.. La prochaine �tape c'est.. Hum... Attendez voir..";

        D607206.TagDialogueSuivant = 607207;

        D607206.Priorite = 9;

        DicoDialogue6.Add(607206, D607206);



        Dialogues D607207 = new Dialogues();

        D607207.TexteDialogue = "Coloniser l'Univers ! Nous allons maitenant �tendre notre renomm�e jusqu'aux confins de la Voie Lact�e !";

        D607207.TagDialogueSuivant = 607208;

        D607207.Priorite = 9;

        DicoDialogue6.Add(607207, D607207);



        Dialogues D607208 = new Dialogues();

        D607208.TexteDialogue = "Enfilez votre scaphandre l'ami, l'oeil de l'Univers nous apelle !";

        D607208.TagDialogueSuivant = 607209;

        D607208.Priorite = 9;

        DicoDialogue6.Add(607208, D607208);



        Dialogues D607209 = new Dialogues();

        D607209.TexteDialogue = "Haha.";

        D607209.TagDialogueSuivant = 607210;

        D607209.Priorite = 9;

        DicoDialogue6.Add(607209, D607209);



        Dialogues D607210 = new Dialogues();

        D607210.TexteDialogue = "Hmm.";

        D607210.TagDialogueSuivant = 607211;

        D607210.Priorite = 9;

        DicoDialogue6.Add(607210, D607210);



        Dialogues D607211 = new Dialogues();

        D607211.TexteDialogue = "�a...�a ne prend pas c'est �a ?";

        D607211.TagDialogueSuivant = 607302;

        D607211.Priorite = 9;

        DicoDialogue6.Add(607211, D607211);



        Dialogues D607302 = new Dialogues();

        D607302.TexteDialogue = "Je... J'imagine que �a s'arr�te comme �a alors.";

        D607302.TagDialogueSuivant = 607303;

        D607302.Priorite = 9;

        DicoDialogue6.Add(607302, D607302);



        Dialogues D607303 = new Dialogues();

        D607303.TexteDialogue = "Je n'ai plus ni objectifs, ni r�compense pour vous convaincre de continuer de jouer � ce jeu.";

        D607303.TagDialogueSuivant = 607304;

        D607303.Priorite = 9;

        DicoDialogue6.Add(607303, D607303);



        Dialogues D607304 = new Dialogues();

        D607304.TexteDialogue = "J'ai �puis� toute les astuces que je conaissais pour vous amuser et vous conserver jusqu'� ce moment.";

        D607304.TagDialogueSuivant = 607305;

        D607304.Priorite = 9;

        DicoDialogue6.Add(607304, D607304);



        Dialogues D607305 = new Dialogues();

        D607305.TexteDialogue = "Je... J'espere que vous avez quand m�me retenu un truc ou deux pendant ce jeu-vid�o.";

        D607305.TagDialogueSuivant = 607306;

        D607305.Priorite = 9;

        DicoDialogue6.Add(607305, D607305);



        Dialogues D607306 = new Dialogues();

        D607306.TexteDialogue = "Pour ma part je.. J'ai l'impression que j'aurai pu. J'aurai pu apprendre quelque chose. Que l'issu aurait pu �tre diff�rente.";

        D607306.TagDialogueSuivant = 607307;

        D607306.Priorite = 9;

        DicoDialogue6.Add(607306, D607306);



        Dialogues D607307 = new Dialogues();

        D607307.TexteDialogue = "Mais j'ai �crit cette pi�ce, et je sais que c'est ainsi qu'elle doit se terminer.";

        D607307.TagDialogueSuivant = 607308;

        D607307.Priorite = 9;

        DicoDialogue6.Add(607307, D607307);



        Dialogues D607308 = new Dialogues();

        D607308.TexteDialogue = "Travailler avec vous a �t�... Au revoir, joueur dont j'ignore le nom.";

        D607308.TagDialogueSuivant = 607309;

        D607308.Priorite = 9;

        DicoDialogue6.Add(607308, D607308);



        Dialogues D607309 = new Dialogues();

        D607309.TexteDialogue = "Et c'est ainsi que cette pi�ce-ci s'est donc finie.";

        D607309.EvenementSpecial = true;

        D607309.Priorite = 9;

        DicoDialogue6.Add(607309, D607309);

        return DicoDialogue6;
    }

    //private void Start()
    //{
    //    
    //    foreach (KeyValuePair<int, Dialogues> item in DicoDialogue6)
    //    {
    //        
    //        item.Value.SonDialogue += item.Key.ToString();
    //
    //        int t = 0;
    //        FMOD.Studio.EventInstance instance;
    //        instance = FMODUnity.RuntimeManager.CreateInstance(item.Value.SonDialogue);
    //        FMOD.Studio.EventDescription description;
    //        //Prendre la dur�e du clip de item.Value.SonDialogue et le mettre dans item.Value.TempsDialogue
    //        instance.getDescription(out description);
    //        description.getLength(out t);
    //        item.Value.TempsDialogue = t / 1000;
    //        
    //
    //    //On peut enlever ce if si on a un son qui sapelle "NotDefined.wav" et qui dure 5s de silence, auquel cas on peut mettre la ligne directement et enelver la condition
    //    }
    //    
    //
    //    foreach (KeyValuePair<int, Dialogues> item in DicoDialogue6)
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
