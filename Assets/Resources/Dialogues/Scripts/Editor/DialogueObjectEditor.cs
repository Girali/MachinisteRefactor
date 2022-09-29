using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DialogueDictionary))]
public class DialogueObjectEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        DialogueDictionary dd = ((DialogueDictionary)target);

        if (GUILayout.Button("Create Data Base"))
            dd.CreateDataBase();

        if (GUILayout.Button("Register All"))
            dd.RegisterAll();
    }
}