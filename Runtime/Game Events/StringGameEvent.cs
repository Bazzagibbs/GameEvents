// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/String GameEvent", fileName = "NewStringEvent", order = 50)]
    public class StringGameEvent : ScriptableObject {
        private HashSet<IGameEventListenable<string>> m_Listeners = new();
        
        public void Invoke(string val) {
            foreach (IGameEventListenable<string> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IGameEventListenable<string> listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IGameEventListenable<string> listener) {
            m_Listeners.Remove(listener);
        }
        
        public static StringGameEvent operator +(StringGameEvent a, IGameEventListenable<string> b) {
            a.AddListener(b);
            return a;
        }
        
        public static StringGameEvent operator -(StringGameEvent a, IGameEventListenable<string> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}