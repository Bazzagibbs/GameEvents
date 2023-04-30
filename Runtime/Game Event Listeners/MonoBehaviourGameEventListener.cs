// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class MonoBehaviourGameEventListener : MonoBehaviour, IGameEventListenable<MonoBehaviour> {
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
   
    [Serializable] 
    public class MonoBehaviourGameEventListenerProp : IGameEventListenable<MonoBehaviour> {
        [SerializeField] private MonoBehaviourGameEvent m_GameEvent;
        private UnityEvent<MonoBehaviour> m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke(MonoBehaviour val) {
            m_OnGameEvent?.Invoke(val);
        }

        public void AddListener(UnityAction<MonoBehaviour> call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction<MonoBehaviour> call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static MonoBehaviourGameEventListenerProp operator +(MonoBehaviourGameEventListenerProp listener, UnityAction<MonoBehaviour> call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static MonoBehaviourGameEventListenerProp operator -(MonoBehaviourGameEventListenerProp listener, UnityAction<MonoBehaviour> call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
}