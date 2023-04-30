// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Long GameEvent", fileName = "NewLongEvent", order = 50)]
    public class LongGameEvent : ScriptableObject {
        private HashSet<IGameEventListenable<long>> m_Listeners = new();
        
        public void Invoke(long val) {
            foreach (IGameEventListenable<long> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IGameEventListenable<long> listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IGameEventListenable<long> listener) {
            m_Listeners.Remove(listener);
        }
        
        public static LongGameEvent operator +(LongGameEvent a, IGameEventListenable<long> b) {
            a.AddListener(b);
            return a;
        }
        
        public static LongGameEvent operator -(LongGameEvent a, IGameEventListenable<long> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}