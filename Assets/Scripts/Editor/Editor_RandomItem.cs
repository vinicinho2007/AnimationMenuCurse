using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RandomItem))]
public class Editor_RandomItem : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        RandomItem randomItem = (RandomItem)target;

        if (GUILayout.Button("Random Lista"))
        {
            if (!randomItem.RandomList()) Debug.LogError("Lista não tem sprites associados!");
        }

        if (GUILayout.Button("Random Item"))
        {
            if (!randomItem.RandomItens()) Debug.LogError("Imagem não associada!");
        }
    }
}