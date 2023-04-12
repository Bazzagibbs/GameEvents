// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Rigidbody2D GameEvent", fileName = "NewRigidbody2DEvent", order = 3)]
    public class Rigidbody2DGameEvent : ScriptableObject {
        private HashSet<Rigidbody2DGameEventListener> m_Listeners = new();
        
        public void Invoke(Rigidbody2D val) {
            foreach (Rigidbody2DGameEventListener listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(Rigidbody2DGameEventListener listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(Rigidbody2DGameEventListener listener) {
            m_Listeners.Remove(listener);
        }
        
        public static Rigidbody2DGameEvent operator +(Rigidbody2DGameEvent a, Rigidbody2DGameEventListener b) {
            a.AddListener(b);
            return a;
        }
        
        public static Rigidbody2DGameEvent operator -(Rigidbody2DGameEvent a, Rigidbody2DGameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
}