// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Rigidbody GameEvent", fileName = "NewRigidbodyEvent", order = 50)]
    public class RigidbodyGameEvent : ScriptableObject {
        private HashSet<IGameEventListenable<Rigidbody>> m_Listeners = new();
        
        public void Invoke(Rigidbody val) {
            foreach (IGameEventListenable<Rigidbody> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IGameEventListenable<Rigidbody> listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IGameEventListenable<Rigidbody> listener) {
            m_Listeners.Remove(listener);
        }
        
        public static RigidbodyGameEvent operator +(RigidbodyGameEvent a, IGameEventListenable<Rigidbody> b) {
            a.AddListener(b);
            return a;
        }
        
        public static RigidbodyGameEvent operator -(RigidbodyGameEvent a, IGameEventListenable<Rigidbody> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}