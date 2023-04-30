// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class Vector3GameEventListener : MonoBehaviour, IGameEventListenable<Vector3> {
        [SerializeField] private Vector3GameEvent m_GameEvent;
        [SerializeField] private UnityEvent<Vector3> m_OnGameEvent;
        
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
        
        public void Invoke(Vector3 val){
            m_OnGameEvent?.Invoke(val);
        }
    }
   
    [Serializable] 
    public class Vector3GameEventListenerProp : IGameEventListenable<Vector3> {
        [SerializeField] private Vector3GameEvent m_GameEvent;
        private UnityEvent<Vector3> m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke(Vector3 val) {
            m_OnGameEvent?.Invoke(val);
        }

        public void AddListener(UnityAction<Vector3> call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction<Vector3> call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static Vector3GameEventListenerProp operator +(Vector3GameEventListenerProp listener, UnityAction<Vector3> call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static Vector3GameEventListenerProp operator -(Vector3GameEventListenerProp listener, UnityAction<Vector3> call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
}