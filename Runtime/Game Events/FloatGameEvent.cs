// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Float GameEvent", fileName = "NewFloatEvent", order = 50)]
    public class FloatGameEvent : ScriptableObject {
        private HashSet<IGameEventListenable<float>> m_Listeners = new();
        
        public void Invoke(float val) {
            foreach (IGameEventListenable<float> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IGameEventListenable<float> listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IGameEventListenable<float> listener) {
            m_Listeners.Remove(listener);
        }
        
        public static FloatGameEvent operator +(FloatGameEvent a, IGameEventListenable<float> b) {
            a.AddListener(b);
            return a;
        }
        
        public static FloatGameEvent operator -(FloatGameEvent a, IGameEventListenable<float> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}