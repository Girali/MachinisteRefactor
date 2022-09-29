using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncomfortManager : MonoBehaviour
{
    public bool firstBlocDropped = false;

    public float frustration = 0;
    public float boredom = 0;

    public float timeToCalm = 10;
    float timeWithoutFrustration = 0;
    float lastFrustration = 0;

    public float durationBoredWithoutFail = 30;
    float lastFailTime = 0;

    bool passiveBoredomWaiting = false;
    public int passiveBoredomGain = 0;

    public float questDurationTolerance = 40;
    bool questActive = false;
    float timeStartQuest = 0;
    bool questBoredomIsWaiting = false;

    public int blocCount = 0;
    public int ennemyCount = 0;
    public int chestCount = 0;
    public int allyCount = 0;
    void Update()
    {
        if(frustration == lastFrustration)
        {
            //La frustration baisse toute les 10s
            timeWithoutFrustration += Time.deltaTime;
            if(timeWithoutFrustration >= timeToCalm)
            {
                frustration -= 10;
                timeWithoutFrustration = 0;
            }
            //Ennui si 0 échec
            if(Time.time > lastFailTime + durationBoredWithoutFail)
            {
                boredom += 25;
                lastFailTime = Time.time;
            }
        } else
        {
            lastFrustration = frustration;
            lastFailTime = Time.time;
        }

        // Si la quête en cours n'est pas réussie après un certain temps
        if(questActive && !questBoredomIsWaiting)
        {
            if(Time.time > timeStartQuest + questDurationTolerance)
            {
                questBoredomIsWaiting = true;
                StartCoroutine("QuestBoredom");
            }
        }

        // +5 Ennui toutes les 10s
        if(!passiveBoredomWaiting)
        {
            passiveBoredomWaiting = true;
            StartCoroutine("PassiveBoredom");
            
        }

        if(blocCount<0)
        {
            blocCount = 0;
        }
        if (ennemyCount < 0)
        {
            ennemyCount = 0;
        }
        if (chestCount < 0)
        {
            chestCount = 0;
        }
        if (allyCount < 0)
        {
            allyCount = 0;
        }

        //Valeurs toujours >0
        if (frustration < 0 || !firstBlocDropped)
        {
            frustration = 0;
        }
        if (boredom < 0 || !firstBlocDropped)
        {
            boredom = 0;
        }

        // Départ cible
        if (frustration>=100 || boredom >= 100)
        {
            GetComponent<TargetManager>().StartCoroutine("NextTarget");
        }
    }

    IEnumerator PassiveBoredom()
    {
        yield return new WaitForSeconds(10);
        boredom += 10 + passiveBoredomGain;
        passiveBoredomGain += 3;
        passiveBoredomWaiting = false;
    }

    IEnumerator QuestBoredom()
    {
        yield return new WaitForSeconds(1);
        boredom += 1;
        questBoredomIsWaiting = false;
    }

    public void EnnemyHit()
    {
        frustration += 20;
    }

    public void EnnemyKilled()
    {
        boredom -= 10;
    }

    public void ChestOpen()
    {
        frustration -= 15;
        boredom -= 15;
    }

    public void ChestMissed()
    {
        frustration += 15;
    }

    public void QuestTaken()
    {
        boredom -= 5;
        questActive = true;
        timeStartQuest = Time.time;
    }

    public void QuestSucceed()
    {
        frustration -= 30;
        boredom -= 30;
        questActive = false;
    }

    public void ActorStuck()
    {
        frustration += 100;
    }

    public void blocDrop()
    {
        blocCount++;
        ennemyCount--;
        chestCount--;
        allyCount--;
        if (blocCount > GetComponent<TargetManager>().ActualTarget().blockTolerance)
        {
            boredom += 20;
            Debug.Log("Trop de blocs");
        }
    }

    public void ennemyDrop()
    {
        blocCount--;
        ennemyCount++;
        chestCount--;
        allyCount--;
        if (ennemyCount > GetComponent<TargetManager>().ActualTarget().ennemyTolerance)
        {
            boredom += 20;
            Debug.Log("Trop d'ennemis");
        }
    }
    public void chestDrop()
    {
        blocCount-=3;
        ennemyCount-=3;
        chestCount++;
        allyCount--;
        if (chestCount > GetComponent<TargetManager>().ActualTarget().chestTolerance)
        {
            boredom += 20;
            Debug.Log("Trop de coffres");
        }
    }
    public void allyDrop()
    {
        blocCount -= 5;
        ennemyCount -= 5;
        chestCount-=2;
        allyCount++;
        if (allyCount > GetComponent<TargetManager>().ActualTarget().allyTolerance)
        {
            boredom += 20;
            Debug.Log("Trop d'alliés");
        }
    }

}
