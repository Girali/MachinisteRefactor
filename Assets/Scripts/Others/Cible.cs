using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Cible 
{
    public ControlActor.MoveCode movePattern;

    public float biWaitTime = 0;
    public int biNbJumps = 1;
    public float radDistance = 1f;
    public QuestManager.questTaking questDecisions;
    public Sprite normalFace;
    public Sprite boredFace;
    public Sprite angryFace;

    public int blockTolerance = 12;
    public int ennemyTolerance = 9;
    public int chestTolerance = 5;
    public int allyTolerance = 4;
    
    // Constructor for creating a biphase-type player //
    public Cible(ControlActor.MoveCode mp, float WaitTime, int NbJumps, QuestManager.questTaking questTaking, Sprite normal, Sprite angry, Sprite bored)
    {
        movePattern = mp;
        biWaitTime = WaitTime;
        biNbJumps = NbJumps;
        radDistance = 0;
        questDecisions = questTaking;
        normalFace = normal;
        angryFace = angry;
        boredFace = bored;
    }
    
    // Constructor for creating a radar-type player //
    public Cible(ControlActor.MoveCode mp, float jumpDistance, QuestManager.questTaking questTaking, Sprite normal, Sprite angry, Sprite bored)
    {
        movePattern = mp;
        biWaitTime = 0;
        biNbJumps = 0;
        radDistance = jumpDistance;
        questDecisions = questTaking;
        normalFace = normal;
        angryFace = angry;
        boredFace = bored;
    }

    // Constructor for creating a jumping-type or default-type player //
    public Cible(ControlActor.MoveCode mp, QuestManager.questTaking questTaking, Sprite normal, Sprite angry, Sprite bored)
    {
        movePattern = mp;
        biWaitTime = 0;
        biNbJumps = 0;
        radDistance = 0;
        questDecisions = questTaking;
        normalFace = normal;
        angryFace = angry;
        boredFace = bored;
    }

    public Cible(ControlActor.MoveCode mp)
    {
        movePattern = mp;
        biWaitTime = 0;
        biNbJumps = 0;
        radDistance = 0;
        questDecisions = QuestManager.questTaking.None;
        normalFace = null;
        angryFace = null;
        boredFace = null;
    }
}
