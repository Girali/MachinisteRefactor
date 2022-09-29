using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DialogueDictionary : MonoBehaviour
{
    [SerializeField]
    private Dictionary<int, DialogueObject> dictionnary;// = new List<DialogueObject>();

#if UNITY_EDITOR
    public void CreateDataBase()
    {
        Un_DicoDialogue d1 = GetComponent<Un_DicoDialogue>();
        Deux_DicoDialogue d2 = GetComponent<Deux_DicoDialogue>();
        Trois_DicoDialogue d3 = GetComponent<Trois_DicoDialogue>();
        Quatre_DicoDialogue d4 = GetComponent<Quatre_DicoDialogue>();
        Cinq_DicoDialogue d5 = GetComponent<Cinq_DicoDialogue>();
        Six_DicoDialogue d6 = GetComponent<Six_DicoDialogue>();

        dictionnary = new Dictionary<int, DialogueObject>();

        #region CreateData
        var dd1 = d1.Init();
        foreach (var item in dd1)
        {
            DialogueObject d = ScriptableObject.CreateInstance<DialogueObject>();
            d.Copy(item.Value);
            d.ID = item.Key;

            string path = "Assets/Dialogues/" + item.Key + ".asset";
            AssetDatabase.CreateAsset(d, path);
            dictionnary.Add(item.Key, d);
        }

        var dd2 = d2.Init();
        foreach (var item in dd2)
        {
            DialogueObject d = ScriptableObject.CreateInstance<DialogueObject>();
            d.Copy(item.Value);
            d.ID = item.Key;

            string path = "Assets/Dialogues/" + item.Key + ".asset";
            AssetDatabase.CreateAsset(d, path);
            dictionnary.Add(item.Key, d);
        }

        var dd3 = d3.Init();
        foreach (var item in dd3)
        {
            DialogueObject d = ScriptableObject.CreateInstance<DialogueObject>();
            d.Copy(item.Value);
            d.ID = item.Key;

            string path = "Assets/Dialogues/" + item.Key + ".asset";
            AssetDatabase.CreateAsset(d, path);
            dictionnary.Add(item.Key, d);
        }

        var dd4 = d4.Init();
        foreach (var item in dd4)
        {
            DialogueObject d = ScriptableObject.CreateInstance<DialogueObject>();
            d.Copy(item.Value);
            d.ID = item.Key;

            string path = "Assets/Dialogues/" + item.Key + ".asset";
            AssetDatabase.CreateAsset(d, path);
            dictionnary.Add(item.Key, d);
        }

        var dd5 = d5.Init();
        foreach (var item in dd5)
        {
            DialogueObject d = ScriptableObject.CreateInstance<DialogueObject>();
            d.Copy(item.Value);
            d.ID = item.Key;

            string path = "Assets/Dialogues/" + item.Key + ".asset";
            AssetDatabase.CreateAsset(d, path);
            dictionnary.Add(item.Key, d);
        }

        var dd6 = d6.Init();
        foreach (var item in dd6)
        {
            DialogueObject d = ScriptableObject.CreateInstance<DialogueObject>();
            d.Copy(item.Value);
            d.ID = item.Key;

            string path = "Assets/Dialogues/" + item.Key + ".asset";
            AssetDatabase.CreateAsset(d, path);
            dictionnary.Add(item.Key, d);
        }
        #endregion

        #region SetLinks
        foreach (var item in dd1)
        {
            if (item.Value.TagDialogueSuivant != 0)
                dictionnary[item.Key].TagDialogueSuivant = dictionnary[item.Value.TagDialogueSuivant];

            if (item.Value.DoiventEtreLu != null)
            {
                dictionnary[item.Key].DoiventEtreLu = new List<DialogueObject>();
                foreach (int i in item.Value.DoiventEtreLu)
                {
                    dictionnary[item.Key].DoiventEtreLu.Add(dictionnary[i]);
                }
            }
        }

        foreach (var item in dd2)
        {
            if (item.Value.TagDialogueSuivant != 0)
                dictionnary[item.Key].TagDialogueSuivant = dictionnary[item.Value.TagDialogueSuivant];

            if (item.Value.DoiventEtreLu != null)
            {
                dictionnary[item.Key].DoiventEtreLu = new List<DialogueObject>();
                foreach (int i in item.Value.DoiventEtreLu)
                {
                    dictionnary[item.Key].DoiventEtreLu.Add(dictionnary[i]);
                }
            }
        }

        foreach (var item in dd3)
        {
            if (item.Value.TagDialogueSuivant != 0)
                dictionnary[item.Key].TagDialogueSuivant = dictionnary[item.Value.TagDialogueSuivant];

            if (item.Value.DoiventEtreLu != null)
            {
                dictionnary[item.Key].DoiventEtreLu = new List<DialogueObject>();
                foreach (int i in item.Value.DoiventEtreLu)
                {
                    dictionnary[item.Key].DoiventEtreLu.Add(dictionnary[i]);
                }
            }
        }

        foreach (var item in dd4)
        {
            if (item.Value.TagDialogueSuivant != 0)
                dictionnary[item.Key].TagDialogueSuivant = dictionnary[item.Value.TagDialogueSuivant];

            if (item.Value.DoiventEtreLu != null)
            {
                dictionnary[item.Key].DoiventEtreLu = new List<DialogueObject>();
                foreach (int i in item.Value.DoiventEtreLu)
                {
                    dictionnary[item.Key].DoiventEtreLu.Add(dictionnary[i]);
                }
            }
        }

        foreach (var item in dd5)
        {
            if (item.Value.TagDialogueSuivant != 0)
                dictionnary[item.Key].TagDialogueSuivant = dictionnary[item.Value.TagDialogueSuivant];

            if (item.Value.DoiventEtreLu != null)
            {
                dictionnary[item.Key].DoiventEtreLu = new List<DialogueObject>();
                foreach (int i in item.Value.DoiventEtreLu)
                {
                    dictionnary[item.Key].DoiventEtreLu.Add(dictionnary[i]);
                }
            }
        }

        foreach (var item in dd6)
        {
            if (item.Value.TagDialogueSuivant != 0)
                dictionnary[item.Key].TagDialogueSuivant = dictionnary[item.Value.TagDialogueSuivant];

            if (item.Value.DoiventEtreLu != null)
            {
                dictionnary[item.Key].DoiventEtreLu = new List<DialogueObject>();
                foreach (int i in item.Value.DoiventEtreLu)
                {
                    dictionnary[item.Key].DoiventEtreLu.Add(dictionnary[i]);
                }
            }
        }
        #endregion

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        EditorUtility.FocusProjectWindow();
        //Selection.activeObject = d;
    }

    public void RegisterAll()
    {
        Object[] dialogues = AssetDatabase.LoadAllAssetsAtPath("Assets/Dialogues");
        Dictionary<int, DialogueObject> dictionnary = new Dictionary<int, DialogueObject>();
        foreach (var item in dialogues)
        {
            DialogueObject o = (DialogueObject)item;
            dictionnary.Add(o.ID, o);
            AssetDatabase.SaveAssetIfDirty(this);
        }
    }
#endif

    public DialogueObject FindDialogueByTag(int i)
    {
        return dictionnary[i];
    }
}
