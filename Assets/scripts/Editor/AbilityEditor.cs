using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AbilityData))]
public class AbilityEditor : Editor
{
    public override void OnInspectorGUI()
    {
        AbilityData data = (AbilityData)target;

        if (data.icon == null)
        {
            EditorGUILayout.HelpBox("Warning: This ability has no Sprite icon assigned!", MessageType.Warning);
        }

        EditorGUILayout.BeginVertical("box");
        EditorGUILayout.LabelField("Base Identity", EditorStyles.boldLabel);
        data.abilityName = EditorGUILayout.TextField("Name", data.abilityName);
        data.icon = (Sprite)EditorGUILayout.ObjectField("Icon", data.icon, typeof(Sprite), false);
        EditorGUILayout.EndVertical();

        EditorGUILayout.Space();
        EditorGUILayout.BeginVertical("helpbox");
        EditorGUILayout.LabelField("Ability Effects", EditorStyles.boldLabel);

        SerializedProperty effectsProp = serializedObject.FindProperty("effects");
        EditorGUILayout.PropertyField(effectsProp, true); 

        serializedObject.ApplyModifiedProperties();
        EditorGUILayout.EndVertical();

        EditorGUILayout.Space();
        GUI.backgroundColor = Color.green;
        if (GUILayout.Button("Preview Ability Logic", GUILayout.Height(30)))
        {
            data.TriggerPreview();
        }
        GUI.backgroundColor = Color.white;
    }
}