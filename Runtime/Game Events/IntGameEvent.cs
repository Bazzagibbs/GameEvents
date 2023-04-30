// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Int GameEvent", fileName = "NewIntEvent", order = 50)]
    public class IntGameEvent : ScriptableObject {
        private HashSet<IGameEventListenable<int>> m_Listeners = new();
        
        public void Invoke(int val) {
            foreach (IGameEventListenable<int> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IGameEventListenable<int> listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IGameEventListenable<int> listener) {
            m_Listeners.Remove(listener);
        }
        
        public static IntGameEvent operator +(IntGameEvent a, IGameEventListenable<int> b) {
            a.AddListener(b);
            return a;
        }
        
        public static IntGameEvent operator -(IntGameEvent a, IGameEventListenable<int> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}