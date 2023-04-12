using UnityEngine;
using UnityEngine.Events;

namespace BazzaGibbs.GameEvents {
    public class GameEventListener : MonoBehaviour {
        [SerializeField] private GameEvent m_GameEvent;
        [SerializeField] private UnityEvent m_OnGameEvent;

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

        public void Invoke() {
            m_OnGameEvent?.Invoke();
        }
    }
}