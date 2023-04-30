// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class Vector2GameEventListener : MonoBehaviour, IGameEventListenable<Vector2> {
        [SerializeField] private Vector2GameEvent m_GameEvent;
        [SerializeField] private UnityEvent<Vector2> m_OnGameEvent;
        
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
        
        public void Invoke(Vector2 val){
            m_OnGameEvent?.Invoke(val);
        }
    }
   
    [Serializable] 
    public class Vector2GameEventListenerProp : IGameEventListenable<Vector2> {
        [SerializeField] private Vector2GameEvent m_GameEvent;
        private UnityEvent<Vector2> m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke(Vector2 val) {
            m_OnGameEvent?.Invoke(val);
        }

        public void AddListener(UnityAction<Vector2> call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction<Vector2> call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static Vector2GameEventListenerProp operator +(Vector2GameEventListenerProp listener, UnityAction<Vector2> call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static Vector2GameEventListenerProp operator -(Vector2GameEventListenerProp listener, UnityAction<Vector2> call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
}