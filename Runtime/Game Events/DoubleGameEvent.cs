// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Double GameEvent", fileName = "NewDoubleEvent", order = 3)]
    public class DoubleGameEvent : ScriptableObject {
        private HashSet<DoubleGameEventListener> m_Listeners = new();
        
        public void Invoke(double val) {
            foreach (DoubleGameEventListener listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(DoubleGameEventListener listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(DoubleGameEventListener listener) {
            m_Listeners.Remove(listener);
        }
        
        public static DoubleGameEvent operator +(DoubleGameEvent a, DoubleGameEventListener b) {
            a.AddListener(b);
            return a;
        }
        
        public static DoubleGameEvent operator -(DoubleGameEvent a, DoubleGameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
}