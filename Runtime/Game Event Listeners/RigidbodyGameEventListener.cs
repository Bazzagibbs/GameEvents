// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class RigidbodyGameEventListener : MonoBehaviour, IGameEventListenable<Rigidbody> {
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
   
    [Serializable] 
    public class RigidbodyGameEventListenerProp : IGameEventListenable<Rigidbody> {
        [SerializeField] private RigidbodyGameEvent m_GameEvent;
        private UnityEvent<Rigidbody> m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke(Rigidbody val) {
            m_OnGameEvent?.Invoke(val);
        }

        public void AddListener(UnityAction<Rigidbody> call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction<Rigidbody> call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static RigidbodyGameEventListenerProp operator +(RigidbodyGameEventListenerProp listener, UnityAction<Rigidbody> call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static RigidbodyGameEventListenerProp operator -(RigidbodyGameEventListenerProp listener, UnityAction<Rigidbody> call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
}