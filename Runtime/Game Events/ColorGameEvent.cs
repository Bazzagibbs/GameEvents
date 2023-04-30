// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Color GameEvent", fileName = "NewColorEvent", order = 50)]
    public class ColorGameEvent : ScriptableObject {
        private HashSet<IGameEventListenable<Color>> m_Listeners = new();
        
        public void Invoke(Color val) {
            foreach (IGameEventListenable<Color> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IGameEventListenable<Color> listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IGameEventListenable<Color> listener) {
            m_Listeners.Remove(listener);
        }
        
        public static ColorGameEvent operator +(ColorGameEvent a, IGameEventListenable<Color> b) {
            a.AddListener(b);
            return a;
        }
        
        public static ColorGameEvent operator -(ColorGameEvent a, IGameEventListenable<Color> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}