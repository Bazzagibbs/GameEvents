// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/String GameEvent", fileName = "NewStringEvent", order = 3)]
    public class StringGameEvent : ScriptableObject {
        private HashSet<StringGameEventListener> m_Listeners = new();
        
        public void Invoke(string val) {
            foreach (StringGameEventListener listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(StringGameEventListener listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(StringGameEventListener listener) {
            m_Listeners.Remove(listener);
        }
        
        public static StringGameEvent operator +(StringGameEvent a, StringGameEventListener b) {
            a.AddListener(b);
            return a;
        }
        
        public static StringGameEvent operator -(StringGameEvent a, StringGameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
}