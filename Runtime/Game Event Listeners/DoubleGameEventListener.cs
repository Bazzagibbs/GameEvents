// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class DoubleGameEventListener : MonoBehaviour {
        [SerializeField] private DoubleGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<double> m_OnGameEvent;
        
        private void Awake() {
            if (m_GameEvent != null) {
                m_GameEvent += this;
            }
        }
        
        private void OnDestroy() {
            if (m_GameEvent != null) {
                m_GameEvent -= this;
            }
        }
        
        public void Invoke(double val){
            m_OnGameEvent?.Invoke(val);
        }
    }
}