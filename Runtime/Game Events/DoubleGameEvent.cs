// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Double GameEvent", fileName = "NewDoubleEvent", order = 50)]
    public class DoubleGameEvent : ScriptableObject {
        private HashSet<IGameEventListenable<double>> m_Listeners = new();
        
        public void Invoke(double val) {
            foreach (IGameEventListenable<double> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IGameEventListenable<double> listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IGameEventListenable<double> listener) {
            m_Listeners.Remove(listener);
        }
        
        public static DoubleGameEvent operator +(DoubleGameEvent a, IGameEventListenable<double> b) {
            a.AddListener(b);
            return a;
        }
        
        public static DoubleGameEvent operator -(DoubleGameEvent a, IGameEventListenable<double> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}