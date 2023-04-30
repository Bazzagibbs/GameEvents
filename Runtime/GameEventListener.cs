using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class GameEventListener : MonoBehaviour, IGameEventListenable {
        [SerializeField] private GameEvent m_GameEvent;
        [SerializeField] private UnityEvent m_OnGameEvent;

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

        public void Invoke() {
            m_OnGameEvent?.Invoke();
        }
    }

    
    [Serializable]
    public class GameEventListenerProp : IGameEventListenable {
        [SerializeField] private GameEvent m_GameEvent;
        private UnityEvent m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke() {
            m_OnGameEvent?.Invoke();
        }

        public void AddListener(UnityAction call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static GameEventListenerProp operator +(GameEventListenerProp listener, UnityAction call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static GameEventListenerProp operator -(GameEventListenerProp listener, UnityAction call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
    
}