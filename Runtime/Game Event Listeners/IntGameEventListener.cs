// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class IntGameEventListener : MonoBehaviour, IGameEventListenable<int> {
        [SerializeField] private IntGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<int> m_OnGameEvent;
        
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
        
        public void Invoke(int val){
            m_OnGameEvent?.Invoke(val);
        }
    }
   
    [Serializable] 
    public class IntGameEventListenerProp : IGameEventListenable<int> {
        [SerializeField] private IntGameEvent m_GameEvent;
        private UnityEvent<int> m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke(int val) {
            m_OnGameEvent?.Invoke(val);
        }

        public void AddListener(UnityAction<int> call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction<int> call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static IntGameEventListenerProp operator +(IntGameEventListenerProp listener, UnityAction<int> call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static IntGameEventListenerProp operator -(IntGameEventListenerProp listener, UnityAction<int> call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
}