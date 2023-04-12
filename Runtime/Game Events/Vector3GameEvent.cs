// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Vector3 GameEvent", fileName = "NewVector3Event", order = 3)]
    public class Vector3GameEvent : ScriptableObject {
        private HashSet<Vector3GameEventListener> m_Listeners = new();
        
        public void Invoke(Vector3 val) {
            foreach (Vector3GameEventListener listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(Vector3GameEventListener listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(Vector3GameEventListener listener) {
            m_Listeners.Remove(listener);
        }
        
        public static Vector3GameEvent operator +(Vector3GameEvent a, Vector3GameEventListener b) {
            a.AddListener(b);
            return a;
        }
        
        public static Vector3GameEvent operator -(Vector3GameEvent a, Vector3GameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
}