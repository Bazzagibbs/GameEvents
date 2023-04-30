// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Bool GameEvent", fileName = "NewBoolEvent", order = 50)]
    public class BoolGameEvent : ScriptableObject {
        private HashSet<IGameEventListenable<bool>> m_Listeners = new();
        
        public void Invoke(bool val) {
            foreach (IGameEventListenable<bool> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IGameEventListenable<bool> listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IGameEventListenable<bool> listener) {
            m_Listeners.Remove(listener);
        }
        
        public static BoolGameEvent operator +(BoolGameEvent a, IGameEventListenable<bool> b) {
            a.AddListener(b);
            return a;
        }
        
        public static BoolGameEvent operator -(BoolGameEvent a, IGameEventListenable<bool> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}