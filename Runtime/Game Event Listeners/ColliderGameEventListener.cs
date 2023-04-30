// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class ColliderGameEventListener : MonoBehaviour, IGameEventListenable<Collider> {
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
   
    [Serializable] 
    public class ColliderGameEventListenerProp : IGameEventListenable<Collider> {
        [SerializeField] private ColliderGameEvent m_GameEvent;
        private UnityEvent<Collider> m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke(Collider val) {
            m_OnGameEvent?.Invoke(val);
        }

        public void AddListener(UnityAction<Collider> call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction<Collider> call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static ColliderGameEventListenerProp operator +(ColliderGameEventListenerProp listener, UnityAction<Collider> call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static ColliderGameEventListenerProp operator -(ColliderGameEventListenerProp listener, UnityAction<Collider> call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
}