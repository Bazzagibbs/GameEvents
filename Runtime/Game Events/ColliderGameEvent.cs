// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Collider GameEvent", fileName = "NewColliderEvent", order = 50)]
    public class ColliderGameEvent : ScriptableObject {
        private HashSet<IGameEventListenable<Collider>> m_Listeners = new();
        
        public void Invoke(Collider val) {
            foreach (IGameEventListenable<Collider> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IGameEventListenable<Collider> listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IGameEventListenable<Collider> listener) {
            m_Listeners.Remove(listener);
        }
        
        public static ColliderGameEvent operator +(ColliderGameEvent a, IGameEventListenable<Collider> b) {
            a.AddListener(b);
            return a;
        }
        
        public static ColliderGameEvent operator -(ColliderGameEvent a, IGameEventListenable<Collider> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}