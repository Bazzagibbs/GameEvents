// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class TransformGameEventListener : MonoBehaviour, IGameEventListenable<Transform> {
        [SerializeField] private TransformGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<Transform> m_OnGameEvent;
        
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
        
        public void Invoke(Transform val){
            m_OnGameEvent?.Invoke(val);
        }
    }
   
    [Serializable] 
    public class TransformGameEventListenerProp : IGameEventListenable<Transform> {
        [SerializeField] private TransformGameEvent m_GameEvent;
        private UnityEvent<Transform> m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke(Transform val) {
            m_OnGameEvent?.Invoke(val);
        }

        public void AddListener(UnityAction<Transform> call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction<Transform> call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static TransformGameEventListenerProp operator +(TransformGameEventListenerProp listener, UnityAction<Transform> call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static TransformGameEventListenerProp operator -(TransformGameEventListenerProp listener, UnityAction<Transform> call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
}