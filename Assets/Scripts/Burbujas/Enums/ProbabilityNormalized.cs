using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(SpawnProbability))]

public class ProbabilityNormalized : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var targetConverted = target as SpawnProbability;
        if (targetConverted.Total > 1||targetConverted.Total < 1)
        {
            EditorGUILayout.HelpBox("Weigth sum is not 1, make sure to normalized or things will be very broken", MessageType.Error);
            if (GUILayout.Button("Normalized weigths"))
            {
                targetConverted.NormalizedMeigths();
            }
        }
        


    }
}
