using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(AbilityEntry))]
public class AbilityDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        float gap = 5;
        float width = (position.width - (gap * 4)) / 5;

        Rect nameRect = new Rect(position.x, position.y, width, position.height);
        Rect typeRect = new Rect(position.x + width + gap, position.y, width, position.height);
        Rect costRect = new Rect(position.x + (width + gap) * 2, position.y, width, position.height);
        Rect durRect = new Rect(position.x + (width + gap) * 3, position.y, width, position.height);
        Rect targetRect = new Rect(position.x + (width + gap) * 4, position.y, width, position.height);

        EditorGUI.PropertyField(nameRect, property.FindPropertyRelative("name"), GUIContent.none);
        EditorGUI.PropertyField(typeRect, property.FindPropertyRelative("type"), GUIContent.none);
        EditorGUI.PropertyField(costRect, property.FindPropertyRelative("cost"), GUIContent.none);
        EditorGUI.PropertyField(durRect, property.FindPropertyRelative("duration"), GUIContent.none);
        EditorGUI.PropertyField(targetRect, property.FindPropertyRelative("target"), GUIContent.none);

        EditorGUI.EndProperty();
    }
}