// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Collider2D GameEvent", fileName = "NewCollider2DEvent", order = 3)]
    public class Collider2DGameEvent : ScriptableObject {
        private HashSet<Collider2DGameEventListener> m_Listeners = new();
        
        public void Invoke(Collider2D val) {
            foreach (Collider2DGameEventListener listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(Collider2DGameEventListener listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(Collider2DGameEventListener listener) {
            m_Listeners.Remove(listener);
        }
        
        public static Collider2DGameEvent operator +(Collider2DGameEvent a, Collider2DGameEventListener b) {
            a.AddListener(b);
            return a;
        }
        
        public static Collider2DGameEvent operator -(Collider2DGameEvent a, Collider2DGameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
}