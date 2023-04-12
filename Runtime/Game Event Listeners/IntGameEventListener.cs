// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class IntGameEventListener : MonoBehaviour {
        [SerializeField] private IntGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<int> m_OnGameEvent;
        
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
        
        public void Invoke(int val){
            m_OnGameEvent?.Invoke(val);
        }
    }
}