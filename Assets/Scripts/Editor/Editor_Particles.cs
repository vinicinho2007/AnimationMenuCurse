using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Particles))]
public class Editor_Particles : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Particles particles = (Particles)target;

        if (GUILayout.Button("Play"))
        {
            particles.PlayParticles();
        }

        if (GUILayout.Button("Clear"))
        {
            particles.ClearParticles();
        }
    }
}