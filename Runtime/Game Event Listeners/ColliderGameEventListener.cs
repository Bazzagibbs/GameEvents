// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class ColliderGameEventListener : MonoBehaviour {
        [SerializeField] private ColliderGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<Collider> m_OnGameEvent;
        
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
        
        public void Invoke(Collider val){
            m_OnGameEvent?.Invoke(val);
        }
    }
}