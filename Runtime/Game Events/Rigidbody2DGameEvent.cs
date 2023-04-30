// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Rigidbody2D GameEvent", fileName = "NewRigidbody2DEvent", order = 50)]
    public class Rigidbody2DGameEvent : ScriptableObject {
        private HashSet<IGameEventListenable<Rigidbody2D>> m_Listeners = new();
        
        public void Invoke(Rigidbody2D val) {
            foreach (IGameEventListenable<Rigidbody2D> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IGameEventListenable<Rigidbody2D> listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IGameEventListenable<Rigidbody2D> listener) {
            m_Listeners.Remove(listener);
        }
        
        public static Rigidbody2DGameEvent operator +(Rigidbody2DGameEvent a, IGameEventListenable<Rigidbody2D> b) {
            a.AddListener(b);
            return a;
        }
        
        public static Rigidbody2DGameEvent operator -(Rigidbody2DGameEvent a, IGameEventListenable<Rigidbody2D> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}