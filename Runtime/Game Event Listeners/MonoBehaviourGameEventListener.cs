// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class MonoBehaviourGameEventListener : MonoBehaviour {
        [SerializeField] private MonoBehaviourGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<MonoBehaviour> m_OnGameEvent;
        
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
        
        public void Invoke(MonoBehaviour val){
            m_OnGameEvent?.Invoke(val);
        }
    }
}