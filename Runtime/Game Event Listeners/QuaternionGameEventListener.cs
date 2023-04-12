// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class QuaternionGameEventListener : MonoBehaviour {
        [SerializeField] private QuaternionGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<Quaternion> m_OnGameEvent;
        
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
        
        public void Invoke(Quaternion val){
            m_OnGameEvent?.Invoke(val);
        }
    }
}