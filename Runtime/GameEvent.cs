using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Event", fileName = "NewGameEvent", order = 0)]
    public class GameEvent : ScriptableObject {
        private HashSet<GameEventListener> m_Listeners = new();

        public void Invoke() {
            foreach (GameEventListener listener in m_Listeners) {
                listener.Invoke();
            }
        }

        public void AddListener(GameEventListener listener) {
            m_Listeners.Add(listener);
        }

        public void RemoveListener(GameEventListener listener) {
            m_Listeners.Remove(listener);
        }

        public static GameEvent operator +(GameEvent a, GameEventListener b) {
            a.AddListener(b);
            return a;
        }

        public static GameEvent operator -(GameEvent a, GameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
    
    
    public class BaseGameEvent<T> : ScriptableObject
    {
        private HashSet<BaseGameEventListener<T>> m_Listeners = new();

        public void Invoke(T val) {
            foreach (BaseGameEventListener<T> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }

        public void AddListener(BaseGameEventListener<T> listener) {
            m_Listeners.Add(listener);
        }

        public void RemoveListener(BaseGameEventListener<T> listener) {
            m_Listeners.Remove(listener);
        }

        public static BaseGameEvent<T> operator +(BaseGameEvent<T> a, BaseGameEventListener<T> b) {
            a.AddListener(b);
            return a;
        }

        public static BaseGameEvent<T> operator -(BaseGameEvent<T> a, BaseGameEventListener<T> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}