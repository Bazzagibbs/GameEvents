using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/GameEvent", fileName = "NewGameEvent", order = 0)]
    public class GameEvent : ScriptableObject {
        private HashSet<IGameEventListenable> m_Listeners = new();

        public void Invoke() {
            foreach (IGameEventListenable listener in m_Listeners) {
                listener.Invoke();
            }
        }

        public void AddListener(IGameEventListenable listener) {
            m_Listeners.Add(listener);
        }

        public void RemoveListener(IGameEventListenable listener) {
            m_Listeners.Remove(listener);
        }

        public static GameEvent operator +(GameEvent a, IGameEventListenable b) {
            a.AddListener(b);
            return a;
        }

        public static GameEvent operator -(GameEvent a, IGameEventListenable b) {
            a.RemoveListener(b);
            return a;
        }
    }
}