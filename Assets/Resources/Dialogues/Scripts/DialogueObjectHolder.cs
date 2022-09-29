using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


[SerializeField]
[CreateAssetMenu(fileName = "New Dialogue Holder", menuName = "Dialogue/NewDialogueHolder")]
public class DialogueObjectHolder : ScriptableObject
{
    public List<int> dictionnaryId;
    public List<DialogueObject> dictionnary;

    public  DialogueObject this[int i]
    {
        get
        {
            int index = dictionnaryId.FindIndex((t) => t == i);
            return dictionnary[index];
        }
    }

}
