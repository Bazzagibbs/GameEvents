// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class StringGameEventListener : MonoBehaviour, IGameEventListenable<string> {
        [SerializeField] private StringGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<string> m_OnGameEvent;
        
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
        
        public void Invoke(string val){
            m_OnGameEvent?.Invoke(val);
        }
    }
   
    [Serializable] 
    public class StringGameEventListenerProp : IGameEventListenable<string> {
        [SerializeField] private StringGameEvent m_GameEvent;
        private UnityEvent<string> m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke(string val) {
            m_OnGameEvent?.Invoke(val);
        }

        public void AddListener(UnityAction<string> call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction<string> call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static StringGameEventListenerProp operator +(StringGameEventListenerProp listener, UnityAction<string> call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static StringGameEventListenerProp operator -(StringGameEventListenerProp listener, UnityAction<string> call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
}