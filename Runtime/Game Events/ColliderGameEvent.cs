// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Collider GameEvent", fileName = "NewColliderEvent", order = 3)]
    public class ColliderGameEvent : ScriptableObject {
        private HashSet<ColliderGameEventListener> m_Listeners = new();
        
        public void Invoke(Collider val) {
            foreach (ColliderGameEventListener listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(ColliderGameEventListener listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(ColliderGameEventListener listener) {
            m_Listeners.Remove(listener);
        }
        
        public static ColliderGameEvent operator +(ColliderGameEvent a, ColliderGameEventListener b) {
            a.AddListener(b);
            return a;
        }
        
        public static ColliderGameEvent operator -(ColliderGameEvent a, ColliderGameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
}