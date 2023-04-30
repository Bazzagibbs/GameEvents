// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class FloatGameEventListener : MonoBehaviour, IGameEventListenable<float> {
        [SerializeField] private FloatGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<float> m_OnGameEvent;
        
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
        
        public void Invoke(float val){
            m_OnGameEvent?.Invoke(val);
        }
    }
   
    [Serializable] 
    public class FloatGameEventListenerProp : IGameEventListenable<float> {
        [SerializeField] private FloatGameEvent m_GameEvent;
        private UnityEvent<float> m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke(float val) {
            m_OnGameEvent?.Invoke(val);
        }

        public void AddListener(UnityAction<float> call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction<float> call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static FloatGameEventListenerProp operator +(FloatGameEventListenerProp listener, UnityAction<float> call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static FloatGameEventListenerProp operator -(FloatGameEventListenerProp listener, UnityAction<float> call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
}