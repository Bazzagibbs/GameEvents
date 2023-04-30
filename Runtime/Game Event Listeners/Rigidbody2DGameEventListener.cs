// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class Rigidbody2DGameEventListener : MonoBehaviour, IGameEventListenable<Rigidbody2D> {
        [SerializeField] private Rigidbody2DGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<Rigidbody2D> m_OnGameEvent;
        
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
        
        public void Invoke(Rigidbody2D val){
            m_OnGameEvent?.Invoke(val);
        }
    }
   
    [Serializable] 
    public class Rigidbody2DGameEventListenerProp : IGameEventListenable<Rigidbody2D> {
        [SerializeField] private Rigidbody2DGameEvent m_GameEvent;
        private UnityEvent<Rigidbody2D> m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke(Rigidbody2D val) {
            m_OnGameEvent?.Invoke(val);
        }

        public void AddListener(UnityAction<Rigidbody2D> call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction<Rigidbody2D> call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static Rigidbody2DGameEventListenerProp operator +(Rigidbody2DGameEventListenerProp listener, UnityAction<Rigidbody2D> call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static Rigidbody2DGameEventListenerProp operator -(Rigidbody2DGameEventListenerProp listener, UnityAction<Rigidbody2D> call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
}