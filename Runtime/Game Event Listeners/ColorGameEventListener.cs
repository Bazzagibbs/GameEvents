// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class ColorGameEventListener : MonoBehaviour, IGameEventListenable<Color> {
        [SerializeField] private ColorGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<Color> m_OnGameEvent;
        
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
        
        public void Invoke(Color val){
            m_OnGameEvent?.Invoke(val);
        }
    }
   
    [Serializable] 
    public class ColorGameEventListenerProp : IGameEventListenable<Color> {
        [SerializeField] private ColorGameEvent m_GameEvent;
        private UnityEvent<Color> m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke(Color val) {
            m_OnGameEvent?.Invoke(val);
        }

        public void AddListener(UnityAction<Color> call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction<Color> call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static ColorGameEventListenerProp operator +(ColorGameEventListenerProp listener, UnityAction<Color> call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static ColorGameEventListenerProp operator -(ColorGameEventListenerProp listener, UnityAction<Color> call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
}