// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Vector2 GameEvent", fileName = "NewVector2Event", order = 50)]
    public class Vector2GameEvent : ScriptableObject {
        private HashSet<IGameEventListenable<Vector2>> m_Listeners = new();
        
        public void Invoke(Vector2 val) {
            foreach (IGameEventListenable<Vector2> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IGameEventListenable<Vector2> listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IGameEventListenable<Vector2> listener) {
            m_Listeners.Remove(listener);
        }
        
        public static Vector2GameEvent operator +(Vector2GameEvent a, IGameEventListenable<Vector2> b) {
            a.AddListener(b);
            return a;
        }
        
        public static Vector2GameEvent operator -(Vector2GameEvent a, IGameEventListenable<Vector2> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}