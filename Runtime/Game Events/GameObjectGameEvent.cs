// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/GameObject GameEvent", fileName = "NewGameObjectEvent", order = 50)]
    public class GameObjectGameEvent : ScriptableObject {
        private HashSet<IGameEventListenable<GameObject>> m_Listeners = new();
        
        public void Invoke(GameObject val) {
            foreach (IGameEventListenable<GameObject> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IGameEventListenable<GameObject> listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IGameEventListenable<GameObject> listener) {
            m_Listeners.Remove(listener);
        }
        
        public static GameObjectGameEvent operator +(GameObjectGameEvent a, IGameEventListenable<GameObject> b) {
            a.AddListener(b);
            return a;
        }
        
        public static GameObjectGameEvent operator -(GameObjectGameEvent a, IGameEventListenable<GameObject> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}