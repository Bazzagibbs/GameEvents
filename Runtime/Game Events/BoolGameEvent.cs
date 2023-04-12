// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Bool GameEvent", fileName = "NewBoolEvent", order = 2)]
    public class BoolGameEvent : ScriptableObject {
        private HashSet<BoolGameEventListener> m_Listeners = new();
        
        public void Invoke(bool val) {
            foreach (BoolGameEventListener listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(BoolGameEventListener listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(BoolGameEventListener listener) {
            m_Listeners.Remove(listener);
        }
        
        public static BoolGameEvent operator +(BoolGameEvent a, BoolGameEventListener b) {
            a.AddListener(b);
            return a;
        }
        
        public static BoolGameEvent operator -(BoolGameEvent a, BoolGameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
}