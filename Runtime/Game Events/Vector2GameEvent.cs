// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Vector2 GameEvent", fileName = "NewVector2Event", order = 3)]
    public class Vector2GameEvent : ScriptableObject {
        private HashSet<Vector2GameEventListener> m_Listeners = new();
        
        public void Invoke(Vector2 val) {
            foreach (Vector2GameEventListener listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(Vector2GameEventListener listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(Vector2GameEventListener listener) {
            m_Listeners.Remove(listener);
        }
        
        public static Vector2GameEvent operator +(Vector2GameEvent a, Vector2GameEventListener b) {
            a.AddListener(b);
            return a;
        }
        
        public static Vector2GameEvent operator -(Vector2GameEvent a, Vector2GameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
}