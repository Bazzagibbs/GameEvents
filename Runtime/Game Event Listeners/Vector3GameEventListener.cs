// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class Vector3GameEventListener : MonoBehaviour {
        [SerializeField] private Vector3GameEvent m_GameEvent;
        [SerializeField] private UnityEvent<Vector3> m_OnGameEvent;
        
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
        
        public void Invoke(Vector3 val){
            m_OnGameEvent?.Invoke(val);
        }
    }
}