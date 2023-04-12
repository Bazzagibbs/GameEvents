// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class LongGameEventListener : MonoBehaviour {
        [SerializeField] private LongGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<long> m_OnGameEvent;
        
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
        
        public void Invoke(long val){
            m_OnGameEvent?.Invoke(val);
        }
    }
}