using UnityEditor;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CustomPropertyDrawer(typeof(GameEventListenerProp))]
    public class GameEventListenerDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            EditorGUI.BeginProperty(position, label, property);
            int indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;
            SerializedProperty gameEventProp = property.FindPropertyRelative("m_GameEvent");
            EditorGUI.PropertyField(position, gameEventProp, new GUIContent($"{property.name} (Listener)"));
            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }
    }
}