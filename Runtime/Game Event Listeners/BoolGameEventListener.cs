// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class BoolGameEventListener : MonoBehaviour, IGameEventListenable<bool> {
        [SerializeField] private BoolGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<bool> m_OnGameEvent;
        
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
        
        public void Invoke(bool val){
            m_OnGameEvent?.Invoke(val);
        }
    }
   
    [Serializable] 
    public class BoolGameEventListenerProp : IGameEventListenable<bool> {
        [SerializeField] private BoolGameEvent m_GameEvent;
        private UnityEvent<bool> m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke(bool val) {
            m_OnGameEvent?.Invoke(val);
        }

        public void AddListener(UnityAction<bool> call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction<bool> call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static BoolGameEventListenerProp operator +(BoolGameEventListenerProp listener, UnityAction<bool> call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static BoolGameEventListenerProp operator -(BoolGameEventListenerProp listener, UnityAction<bool> call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
}