// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Vector3 GameEvent", fileName = "NewVector3Event", order = 50)]
    public class Vector3GameEvent : ScriptableObject {
        private HashSet<IGameEventListenable<Vector3>> m_Listeners = new();
        
        public void Invoke(Vector3 val) {
            foreach (IGameEventListenable<Vector3> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IGameEventListenable<Vector3> listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IGameEventListenable<Vector3> listener) {
            m_Listeners.Remove(listener);
        }
        
        public static Vector3GameEvent operator +(Vector3GameEvent a, IGameEventListenable<Vector3> b) {
            a.AddListener(b);
            return a;
        }
        
        public static Vector3GameEvent operator -(Vector3GameEvent a, IGameEventListenable<Vector3> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}