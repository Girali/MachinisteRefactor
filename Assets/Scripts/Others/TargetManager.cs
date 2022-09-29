using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    Cible cible0, cible1, cible2, cible3, cible4, cible5, cible6, streamer;

    List<Cible> targetList = new List<Cible>();
    IncomfortManager incomfortManager;

    public int Palier = 1;
    int currentTargetIndex = 0;

    public ControlActor actor;
    public ConveyorBelt conveyor;
    public GameObject grid;
    public SpriteRenderer face;
    public SpriteRenderer eyes;
    public float transitionDuration = 0.8f;

    public Sprite normalFace1;
    public Sprite angryFace1;
    public Sprite boredFace1;

    public FlagSpawn FlagSpawner;

    public float timeToValidateStage1 = 45;
    public float timeToValidateStage2 = 60;
    public float timeToValidateStage3 = 120;

    public int targetSeduced = 0;
    bool actualTargetSeduced = false;
    public float timeSpent = 0;

    public bool TargetPaused = false;
    bool wasPaused = false;
    void Start()
    {
        incomfortManager = GetComponent<IncomfortManager>();
        // SANS CIBLE //
        cible0 = new Cible(ControlActor.MoveCode.None);
        // CIBLES PALIER 1 //
        cible1 = new Cible(ControlActor.MoveCode.Lapin, QuestManager.questTaking.AlwaysTake, normalFace1, angryFace1, boredFace1);
        cible2 = new Cible(ControlActor.MoveCode.Biphase, 4, 1, QuestManager.questTaking.TakeIfEmpty, normalFace1, angryFace1, boredFace1);
        cible3 = new Cible(ControlActor.MoveCode.Biphase, 7, 2, QuestManager.questTaking.AlwaysTake, normalFace1, angryFace1, boredFace1);
        // CIBLES PALIER 2 //
        cible4 = new Cible(ControlActor.MoveCode.Biphase, 3,5, QuestManager.questTaking.AlwaysTake, normalFace1, angryFace1, boredFace1);
        cible5 = new Cible(ControlActor.MoveCode.Biphase, 5, 3, QuestManager.questTaking.TakeIfEmpty, normalFace1, angryFace1, boredFace1);
        cible6 = new Cible(ControlActor.MoveCode.Lapin, QuestManager.questTaking.NeverTake, normalFace1, angryFace1, boredFace1);

        // CIBLE PALIER 3 //
        streamer = new Cible(ControlActor.MoveCode.Lapin, QuestManager.questTaking.AlwaysTake, normalFace1, angryFace1, boredFace1);

        targetList.Add(cible0);
        targetList.Add(cible1);
        targetList.Add(cible2);
        targetList.Add(cible3);
        targetList.Add(cible4);
        targetList.Add(cible5);
        targetList.Add(cible6);
        targetList.Add(streamer);
        refreshActor();

        conveyor.SetOff();
    }

    void Update()
    {
        //Feedbacks inconfort
        if(incomfortManager.frustration >= incomfortManager.boredom)
        {
            if(incomfortManager.frustration >= 70)
            {
                if(face.sprite != targetList[currentTargetIndex].angryFace)
                {
                    Debug.Log("Too angry");
                    face.sprite = targetList[currentTargetIndex].angryFace;
                    switch (Random.Range(1,4))
                    {
                        case 1:
                            DialogueManageur.Instance.ReceptionDialogue(301701);
                            break;
                        case 2:
                            DialogueManageur.Instance.ReceptionDialogue(301801);
                            break;
                        case 3:
                            DialogueManageur.Instance.ReceptionDialogue(301901);
                            break;
                    }
                }
            }
        } else if(incomfortManager.boredom >= incomfortManager.frustration)
        {
            if (incomfortManager.boredom >= 70)
            {
                if(face.sprite != targetList[currentTargetIndex].boredFace)
                {
                    Debug.Log("Too bored");
                    face.sprite = targetList[currentTargetIndex].boredFace;
                    switch (Random.Range(1, 5))
                    {
                        case 1:
                            DialogueManageur.Instance.ReceptionDialogue(301301);
                            break;
                        case 2:
                            DialogueManageur.Instance.ReceptionDialogue(301401);
                            break;
                        case 3:
                            DialogueManageur.Instance.ReceptionDialogue(301501);
                            break;
                        case 4:
                            DialogueManageur.Instance.ReceptionDialogue(301601);
                            break;
                    }
                }

            }
        } 
        if(incomfortManager.boredom < 70 && incomfortManager.frustration < 70)
        {
            face.sprite = targetList[currentTargetIndex].normalFace;
        }

        if (incomfortManager.firstBlocDropped)
        {
            timeSpent += Time.deltaTime;
        }
        
        //Check passage acte
        if(timeSpent >= timeToValidateStage1 && Palier == 1 && !actualTargetSeduced)
        {
            targetSeduced++;
            actualTargetSeduced = true;
        }
        if (timeSpent >= timeToValidateStage2 && Palier == 2 && !actualTargetSeduced)
        {
            targetSeduced++;
            actualTargetSeduced = true;
        }
        if (timeSpent >= timeToValidateStage3 && Palier == 3 && !actualTargetSeduced)
        {
            targetSeduced++;
            actualTargetSeduced = true;
        }
    }

    public IEnumerator NoTarget()
    {
        ClearScene();
        conveyor.SetOff();
        wasPaused = true;
        TargetPaused = true;
        while (TargetPaused)
        {
            incomfortManager.frustration = 0;
            incomfortManager.boredom = 0;
            timeSpent = 0;
            yield return new WaitForEndOfFrame();
        }

    }

    public IEnumerator NextTarget()
    {
        if (!wasPaused)
        {
            //Passage paliers
            if (actualTargetSeduced)
            {
                switch (targetSeduced)
                {
                    case 1:
                        DialogueManageur.Instance.ReceptionDialogue(300301);
                        break;
                    case 2:
                        DialogueManageur.Instance.ReceptionDialogue(300401);
                        break;
                    case 3:
                        Palier++;
                        DialogueManageur.Instance.ReceptionDialogue(302901);
                        break;
                    case 4:
                        DialogueManageur.Instance.ReceptionDialogue(303001);
                        break;
                    case 5:
                        DialogueManageur.Instance.ReceptionDialogue(303101);
                        break;
                    case 6:
                        Palier++;
                        DialogueManageur.Instance.ReceptionDialogue(303201);
                        break;
                    case 7:
                        DialogueManageur.Instance.ReceptionDialogue(307201);
                        StartCoroutine("NoTarget");
                        break;
                }
            }
            else
            {
                switch (Random.Range(1, 4))
                {
                    case 1:
                        DialogueManageur.Instance.ReceptionDialogue(302001);
                        break;
                    case 2:
                        DialogueManageur.Instance.ReceptionDialogue(302101);
                        break;
                    case 3:
                        DialogueManageur.Instance.ReceptionDialogue(302201);
                        break;
                }
            }
        }
        

        ClearScene();

        yield return new WaitForSeconds(transitionDuration);
        if (!TargetPaused)
        {
            //Arrivée cible
            wasPaused = false;
            switch (currentTargetIndex)
            {
                case 0:
                    currentTargetIndex = 1;
                    refreshActor();
                    break;
                case 1:
                    if (Palier == 1)
                    {
                        currentTargetIndex = 2;
                        refreshActor();
                    }
                    else
                    {
                        currentTargetIndex = 4;
                        refreshActor();
                    }
                    break;
                case 2:
                    if (Palier == 1)
                    {
                        currentTargetIndex = 3;
                        refreshActor();
                    }
                    else
                    {
                        currentTargetIndex = 4;
                        refreshActor();
                    }
                    break;
                case 3:
                    if (Palier == 1)
                    {
                        currentTargetIndex = 1;
                        refreshActor();
                    }
                    else
                    {
                        currentTargetIndex = 4;
                        refreshActor();
                    }
                    break;
                case 4:
                    if (Palier == 2)
                    {
                        currentTargetIndex = 5;
                        refreshActor();
                    }
                    else
                    {
                        currentTargetIndex = 7;
                        refreshActor();
                    }
                    break;
                case 5:
                    if (Palier == 2)
                    {
                        currentTargetIndex = 6;
                        refreshActor();
                    }
                    else
                    {
                        currentTargetIndex = 7;
                        refreshActor();
                    }
                    break;
                case 6:
                    if (Palier == 2)
                    {
                        currentTargetIndex = 4;
                        refreshActor();
                    }
                    else
                    {
                        currentTargetIndex = 7;
                        refreshActor();
                    }
                    break;
            }
            //
            conveyor.SetOn();
            face.sprite = targetList[currentTargetIndex].normalFace;
            GetComponent<IncomfortManager>().firstBlocDropped = false;
            timeSpent = 0;
            FlagSpawner.flag1Spawn = false;
            FlagSpawner.flag2Spawn = false;
            FlagSpawner.flag3Spawn = false;
            actualTargetSeduced = false;
            face.enabled = true;
            eyes.enabled = true;

            Debug.Log("Next Target : cible" + currentTargetIndex);
        }

        
    }

    void refreshActor()
    {
        actor.typeMouvement = targetList[currentTargetIndex].movePattern;
        actor.biWaitTime = targetList[currentTargetIndex].biWaitTime;
        actor.radDistance = targetList[currentTargetIndex].radDistance;
        actor.biNbJumps = targetList[currentTargetIndex].biNbJumps;
        actor.questTaking = targetList[currentTargetIndex].questDecisions;
    }

    public Cible ActualTarget()
    {
        return targetList[currentTargetIndex];
    }

    private void ClearScene()
    {
        //reset valeurs
        conveyor.SetOff();
        incomfortManager.blocCount = 0;
        incomfortManager.ennemyCount = 0;
        incomfortManager.chestCount = 0;
        incomfortManager.allyCount = 0;
        incomfortManager.passiveBoredomGain = 0;
        actor.GetComponent<QuestManager>().StopQuest();
        //Départ cible
        actor.typeMouvement = cible0.movePattern;
        incomfortManager.frustration = 0;
        incomfortManager.boredom = 0;
        face.enabled = false;
        eyes.enabled = false;

        //Reset scene
        foreach (Transform child in GameObject.Find("BrickSlots").transform)
        {
            child.GetComponent<DragDrop>().harpagonsOnConveyor = 0;
        }
        foreach (Transform child in conveyor.gameObject.transform)
        {
            if (child.gameObject.tag == "Ally")
            {
                Destroy(child.GetComponent<QuestGiver>().bubble);
            }
            Destroy(child.gameObject);
        }
        foreach (Transform child in grid.transform)
        {
            foreach (Transform bloc in child)
            {
                Destroy(bloc.gameObject);
            }
        }
    }


}
