// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class DoubleGameEventListener : MonoBehaviour, IGameEventListenable<double> {
        [SerializeField] private DoubleGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<double> m_OnGameEvent;
        
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
        
        public void Invoke(double val){
            m_OnGameEvent?.Invoke(val);
        }
    }
   
    [Serializable] 
    public class DoubleGameEventListenerProp : IGameEventListenable<double> {
        [SerializeField] private DoubleGameEvent m_GameEvent;
        private UnityEvent<double> m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke(double val) {
            m_OnGameEvent?.Invoke(val);
        }

        public void AddListener(UnityAction<double> call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction<double> call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static DoubleGameEventListenerProp operator +(DoubleGameEventListenerProp listener, UnityAction<double> call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static DoubleGameEventListenerProp operator -(DoubleGameEventListenerProp listener, UnityAction<double> call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
}