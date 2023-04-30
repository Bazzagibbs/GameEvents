// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class LongGameEventListener : MonoBehaviour, IGameEventListenable<long> {
        [SerializeField] private LongGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<long> m_OnGameEvent;
        
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
        
        public void Invoke(long val){
            m_OnGameEvent?.Invoke(val);
        }
    }
   
    [Serializable] 
    public class LongGameEventListenerProp : IGameEventListenable<long> {
        [SerializeField] private LongGameEvent m_GameEvent;
        private UnityEvent<long> m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke(long val) {
            m_OnGameEvent?.Invoke(val);
        }

        public void AddListener(UnityAction<long> call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction<long> call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static LongGameEventListenerProp operator +(LongGameEventListenerProp listener, UnityAction<long> call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static LongGameEventListenerProp operator -(LongGameEventListenerProp listener, UnityAction<long> call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
}