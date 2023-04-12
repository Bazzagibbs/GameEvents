// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class ColorGameEventListener : MonoBehaviour {
        [SerializeField] private ColorGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<Color> m_OnGameEvent;
        
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
        
        public void Invoke(Color val){
            m_OnGameEvent?.Invoke(val);
        }
    }
}