// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Quaternion GameEvent", fileName = "NewQuaternionEvent", order = 3)]
    public class QuaternionGameEvent : ScriptableObject {
        private HashSet<QuaternionGameEventListener> m_Listeners = new();
        
        public void Invoke(Quaternion val) {
            foreach (QuaternionGameEventListener listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(QuaternionGameEventListener listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(QuaternionGameEventListener listener) {
            m_Listeners.Remove(listener);
        }
        
        public static QuaternionGameEvent operator +(QuaternionGameEvent a, QuaternionGameEventListener b) {
            a.AddListener(b);
            return a;
        }
        
        public static QuaternionGameEvent operator -(QuaternionGameEvent a, QuaternionGameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
}