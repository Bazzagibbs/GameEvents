// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class QuaternionGameEventListener : MonoBehaviour, IGameEventListenable<Quaternion> {
        [SerializeField] private QuaternionGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<Quaternion> m_OnGameEvent;
        
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
        
        public void Invoke(Quaternion val){
            m_OnGameEvent?.Invoke(val);
        }
    }
   
    [Serializable] 
    public class QuaternionGameEventListenerProp : IGameEventListenable<Quaternion> {
        [SerializeField] private QuaternionGameEvent m_GameEvent;
        private UnityEvent<Quaternion> m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke(Quaternion val) {
            m_OnGameEvent?.Invoke(val);
        }

        public void AddListener(UnityAction<Quaternion> call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction<Quaternion> call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static QuaternionGameEventListenerProp operator +(QuaternionGameEventListenerProp listener, UnityAction<Quaternion> call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static QuaternionGameEventListenerProp operator -(QuaternionGameEventListenerProp listener, UnityAction<Quaternion> call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
}