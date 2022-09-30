using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


[SerializeField]
[CreateAssetMenu(fileName = "New Dialogue Holder", menuName = "Dialogue/NewDialogueHolder")]
public class DialogueObjectHolder : ScriptableObject
{
    [SerializeField]
    private List<int> dictionnaryId;
    [SerializeField]
    private List<DialogueObject> dictionnary;

    public int Length
    {
        get
        {
            return dictionnary.Count;
        }
    }

    public DialogueObject GetObject(int i)
    {
        return dictionnary[i];
    }

    public void Init()
    {
        dictionnaryId = new List<int>();
        dictionnary = new List<DialogueObject>();
    }

    public void Add(int i, DialogueObject d)
    {
        dictionnaryId.Add(i);
        dictionnary.Add(d);
    }

    public  DialogueObject this[int i]
    {
        get
        {
            int index = dictionnaryId.FindIndex((t) => t == i);
            return dictionnary[index];
        }
    }

}
