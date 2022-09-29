using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestManager : MonoBehaviour
{
    public bool activeQuest = false;
    public int objNb;
    public QuestGiver.QuestType objType;

    public int currentNb = 0;

    public TextMeshProUGUI questUI;

    private void Update()
    {
     if(currentNb >= objNb && activeQuest)
     {
            SucceedQuest();
     }
       RefreshUI();
    }

    void RefreshUI()
    {
        if(activeQuest)
        {
            switch (objType)
            {
                case QuestGiver.QuestType.Kill:
                    questUI.text = "Kill " + objNb + " ennemies ( " + currentNb + " / " + objNb + " )";
                    break;
                case QuestGiver.QuestType.Collect:
                    questUI.text = "Collect " + objNb + " chests ( " + currentNb + " / " + objNb + " )";
                    break;
                default:
                    questUI.text = "";
                    break;
            }
        } else
        {
            questUI.text = "";
        }
    }

    public bool WantToTakeQuest()
    {
        switch(GetComponent<ControlActor>().questTaking)
        {
            case questTaking.AlwaysTake:
                return true;
            case questTaking.TakeIfEmpty:
                return !activeQuest;
            default:
                return false;
        }
    }

    public void TakeQuest(int objectiveNumber, QuestGiver.QuestType objectiveType)
    {
        GameObject.Find("Targets").GetComponent<IncomfortManager>().QuestTaken();
        activeQuest = true;
        objNb = objectiveNumber;
        objType = objectiveType;
        currentNb = 0;
        RefreshUI();
    }

    public void SucceedQuest()
    {
        activeQuest = false;
        questUI.text = "";
        GameObject.Find("Targets").GetComponent<IncomfortManager>().QuestSucceed();
    }

    public void StopQuest()
    {
        activeQuest = false;
        questUI.text = "";
    }

    public enum questTaking
    {
        None,
        AlwaysTake,
        TakeIfEmpty,
        NeverTake
    }
}
