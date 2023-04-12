// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class Vector2GameEventListener : MonoBehaviour {
        [SerializeField] private Vector2GameEvent m_GameEvent;
        [SerializeField] private UnityEvent<Vector2> m_OnGameEvent;
        
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
        
        public void Invoke(Vector2 val){
            m_OnGameEvent?.Invoke(val);
        }
    }
}