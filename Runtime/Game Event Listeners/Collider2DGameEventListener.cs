// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class Collider2DGameEventListener : MonoBehaviour {
        [SerializeField] private Collider2DGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<Collider2D> m_OnGameEvent;
        
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
        
        public void Invoke(Collider2D val){
            m_OnGameEvent?.Invoke(val);
        }
    }
}