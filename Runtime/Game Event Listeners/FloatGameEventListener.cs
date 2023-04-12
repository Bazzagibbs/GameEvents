// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class FloatGameEventListener : MonoBehaviour {
        [SerializeField] private FloatGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<float> m_OnGameEvent;
        
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
        
        public void Invoke(float val){
            m_OnGameEvent?.Invoke(val);
        }
    }
}