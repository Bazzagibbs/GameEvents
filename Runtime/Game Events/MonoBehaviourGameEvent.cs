// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/MonoBehaviour GameEvent", fileName = "NewMonoBehaviourEvent", order = 3)]
    public class MonoBehaviourGameEvent : ScriptableObject {
        private HashSet<MonoBehaviourGameEventListener> m_Listeners = new();
        
        public void Invoke(MonoBehaviour val) {
            foreach (MonoBehaviourGameEventListener listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(MonoBehaviourGameEventListener listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(MonoBehaviourGameEventListener listener) {
            m_Listeners.Remove(listener);
        }
        
        public static MonoBehaviourGameEvent operator +(MonoBehaviourGameEvent a, MonoBehaviourGameEventListener b) {
            a.AddListener(b);
            return a;
        }
        
        public static MonoBehaviourGameEvent operator -(MonoBehaviourGameEvent a, MonoBehaviourGameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
}