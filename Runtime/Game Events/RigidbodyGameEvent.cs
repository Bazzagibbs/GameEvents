// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Rigidbody GameEvent", fileName = "NewRigidbodyEvent", order = 3)]
    public class RigidbodyGameEvent : ScriptableObject {
        private HashSet<RigidbodyGameEventListener> m_Listeners = new();
        
        public void Invoke(Rigidbody val) {
            foreach (RigidbodyGameEventListener listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(RigidbodyGameEventListener listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(RigidbodyGameEventListener listener) {
            m_Listeners.Remove(listener);
        }
        
        public static RigidbodyGameEvent operator +(RigidbodyGameEvent a, RigidbodyGameEventListener b) {
            a.AddListener(b);
            return a;
        }
        
        public static RigidbodyGameEvent operator -(RigidbodyGameEvent a, RigidbodyGameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
}