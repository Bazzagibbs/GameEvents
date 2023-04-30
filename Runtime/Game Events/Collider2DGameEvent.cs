// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Collider2D GameEvent", fileName = "NewCollider2DEvent", order = 50)]
    public class Collider2DGameEvent : ScriptableObject {
        private HashSet<IGameEventListenable<Collider2D>> m_Listeners = new();
        
        public void Invoke(Collider2D val) {
            foreach (IGameEventListenable<Collider2D> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IGameEventListenable<Collider2D> listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IGameEventListenable<Collider2D> listener) {
            m_Listeners.Remove(listener);
        }
        
        public static Collider2DGameEvent operator +(Collider2DGameEvent a, IGameEventListenable<Collider2D> b) {
            a.AddListener(b);
            return a;
        }
        
        public static Collider2DGameEvent operator -(Collider2DGameEvent a, IGameEventListenable<Collider2D> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}