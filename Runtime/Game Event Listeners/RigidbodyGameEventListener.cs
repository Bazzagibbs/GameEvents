// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class RigidbodyGameEventListener : MonoBehaviour {
        [SerializeField] private RigidbodyGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<Rigidbody> m_OnGameEvent;
        
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
        
        public void Invoke(Rigidbody val){
            m_OnGameEvent?.Invoke(val);
        }
    }
}