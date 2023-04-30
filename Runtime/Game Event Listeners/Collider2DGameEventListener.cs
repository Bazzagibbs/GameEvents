// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class Collider2DGameEventListener : MonoBehaviour, IGameEventListenable<Collider2D> {
        [SerializeField] private Collider2DGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<Collider2D> m_OnGameEvent;
        
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
        
        public void Invoke(Collider2D val){
            m_OnGameEvent?.Invoke(val);
        }
    }
   
    [Serializable] 
    public class Collider2DGameEventListenerProp : IGameEventListenable<Collider2D> {
        [SerializeField] private Collider2DGameEvent m_GameEvent;
        private UnityEvent<Collider2D> m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke(Collider2D val) {
            m_OnGameEvent?.Invoke(val);
        }

        public void AddListener(UnityAction<Collider2D> call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction<Collider2D> call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static Collider2DGameEventListenerProp operator +(Collider2DGameEventListenerProp listener, UnityAction<Collider2D> call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static Collider2DGameEventListenerProp operator -(Collider2DGameEventListenerProp listener, UnityAction<Collider2D> call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
}