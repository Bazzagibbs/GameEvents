// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Quaternion GameEvent", fileName = "NewQuaternionEvent", order = 50)]
    public class QuaternionGameEvent : ScriptableObject {
        private HashSet<IGameEventListenable<Quaternion>> m_Listeners = new();
        
        public void Invoke(Quaternion val) {
            foreach (IGameEventListenable<Quaternion> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IGameEventListenable<Quaternion> listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IGameEventListenable<Quaternion> listener) {
            m_Listeners.Remove(listener);
        }
        
        public static QuaternionGameEvent operator +(QuaternionGameEvent a, IGameEventListenable<Quaternion> b) {
            a.AddListener(b);
            return a;
        }
        
        public static QuaternionGameEvent operator -(QuaternionGameEvent a, IGameEventListenable<Quaternion> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}