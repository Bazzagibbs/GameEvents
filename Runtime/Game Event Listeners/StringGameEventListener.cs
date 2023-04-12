// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class StringGameEventListener : MonoBehaviour {
        [SerializeField] private StringGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<string> m_OnGameEvent;
        
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
        
        public void Invoke(string val){
            m_OnGameEvent?.Invoke(val);
        }
    }
}