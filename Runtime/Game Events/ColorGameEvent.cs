// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Color GameEvent", fileName = "NewColorEvent", order = 3)]
    public class ColorGameEvent : ScriptableObject {
        private HashSet<ColorGameEventListener> m_Listeners = new();
        
        public void Invoke(Color val) {
            foreach (ColorGameEventListener listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(ColorGameEventListener listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(ColorGameEventListener listener) {
            m_Listeners.Remove(listener);
        }
        
        public static ColorGameEvent operator +(ColorGameEvent a, ColorGameEventListener b) {
            a.AddListener(b);
            return a;
        }
        
        public static ColorGameEvent operator -(ColorGameEvent a, ColorGameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
}