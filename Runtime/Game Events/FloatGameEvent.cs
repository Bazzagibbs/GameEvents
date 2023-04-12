// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Float GameEvent", fileName = "NewFloatEvent", order = 1)]
    public class FloatGameEvent : ScriptableObject {
        private HashSet<FloatGameEventListener> m_Listeners = new();
        
        public void Invoke(float val) {
            foreach (FloatGameEventListener listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(FloatGameEventListener listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(FloatGameEventListener listener) {
            m_Listeners.Remove(listener);
        }
        
        public static FloatGameEvent operator +(FloatGameEvent a, FloatGameEventListener b) {
            a.AddListener(b);
            return a;
        }
        
        public static FloatGameEvent operator -(FloatGameEvent a, FloatGameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
}