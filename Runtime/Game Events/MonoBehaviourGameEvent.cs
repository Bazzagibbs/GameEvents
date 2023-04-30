// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/MonoBehaviour GameEvent", fileName = "NewMonoBehaviourEvent", order = 50)]
    public class MonoBehaviourGameEvent : ScriptableObject {
        private HashSet<IGameEventListenable<MonoBehaviour>> m_Listeners = new();
        
        public void Invoke(MonoBehaviour val) {
            foreach (IGameEventListenable<MonoBehaviour> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IGameEventListenable<MonoBehaviour> listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IGameEventListenable<MonoBehaviour> listener) {
            m_Listeners.Remove(listener);
        }
        
        public static MonoBehaviourGameEvent operator +(MonoBehaviourGameEvent a, IGameEventListenable<MonoBehaviour> b) {
            a.AddListener(b);
            return a;
        }
        
        public static MonoBehaviourGameEvent operator -(MonoBehaviourGameEvent a, IGameEventListenable<MonoBehaviour> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}