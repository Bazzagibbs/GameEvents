// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Int GameEvent", fileName = "NewIntEvent", order = 2)]
    public class IntGameEvent : ScriptableObject {
        private HashSet<IntGameEventListener> m_Listeners = new();
        
        public void Invoke(int val) {
            foreach (IntGameEventListener listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IntGameEventListener listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IntGameEventListener listener) {
            m_Listeners.Remove(listener);
        }
        
        public static IntGameEvent operator +(IntGameEvent a, IntGameEventListener b) {
            a.AddListener(b);
            return a;
        }
        
        public static IntGameEvent operator -(IntGameEvent a, IntGameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
}