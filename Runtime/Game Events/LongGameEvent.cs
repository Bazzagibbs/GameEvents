// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Long GameEvent", fileName = "NewLongEvent", order = 3)]
    public class LongGameEvent : ScriptableObject {
        private HashSet<LongGameEventListener> m_Listeners = new();
        
        public void Invoke(long val) {
            foreach (LongGameEventListener listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(LongGameEventListener listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(LongGameEventListener listener) {
            m_Listeners.Remove(listener);
        }
        
        public static LongGameEvent operator +(LongGameEvent a, LongGameEventListener b) {
            a.AddListener(b);
            return a;
        }
        
        public static LongGameEvent operator -(LongGameEvent a, LongGameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
}