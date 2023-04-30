// Generated script for BazzaGibbs.GameEvents package

using System;
using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class GameObjectGameEventListener : MonoBehaviour, IGameEventListenable<GameObject> {
        [SerializeField] private GameObjectGameEvent m_GameEvent;
        [SerializeField] private UnityEvent<GameObject> m_OnGameEvent;
        
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
        
        public void Invoke(GameObject val){
            m_OnGameEvent?.Invoke(val);
        }
    }
   
    [Serializable] 
    public class GameObjectGameEventListenerProp : IGameEventListenable<GameObject> {
        [SerializeField] private GameObjectGameEvent m_GameEvent;
        private UnityEvent<GameObject> m_OnGameEvent = new();
        private bool m_IsSubscribed;
        
        public void Invoke(GameObject val) {
            m_OnGameEvent?.Invoke(val);
        }

        public void AddListener(UnityAction<GameObject> call) {
            m_OnGameEvent.AddListener(call);
            if (m_IsSubscribed == false) {
                m_GameEvent.AddListener(this);
                m_IsSubscribed = true;
            }
        }

        public void RemoveListener(UnityAction<GameObject> call) {
            m_OnGameEvent.RemoveListener(call);
            if (m_OnGameEvent == null) {
                m_GameEvent.RemoveListener(this);
                m_IsSubscribed = false;
            }
        }
        
        public static GameObjectGameEventListenerProp operator +(GameObjectGameEventListenerProp listener, UnityAction<GameObject> call) {
            listener.AddListener(call);
            return listener;
        }
        
        public static GameObjectGameEventListenerProp operator -(GameObjectGameEventListenerProp listener, UnityAction<GameObject> call) {
            listener.RemoveListener(call);
            return listener;
        }
    }
}