// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/GameObject GameEvent", fileName = "NewGameObjectEvent", order = 3)]
    public class GameObjectGameEvent : ScriptableObject {
        private HashSet<GameObjectGameEventListener> m_Listeners = new();
        
        public void Invoke(GameObject val) {
            foreach (GameObjectGameEventListener listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(GameObjectGameEventListener listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(GameObjectGameEventListener listener) {
            m_Listeners.Remove(listener);
        }
        
        public static GameObjectGameEvent operator +(GameObjectGameEvent a, GameObjectGameEventListener b) {
            a.AddListener(b);
            return a;
        }
        
        public static GameObjectGameEvent operator -(GameObjectGameEvent a, GameObjectGameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
}