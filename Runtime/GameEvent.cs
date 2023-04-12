using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/GameEvent", fileName = "NewGameEvent", order = 0)]
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
}