// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Transform GameEvent", fileName = "NewTransformEvent", order = 50)]
    public class TransformGameEvent : ScriptableObject {
        private HashSet<IGameEventListenable<Transform>> m_Listeners = new();
        
        public void Invoke(Transform val) {
            foreach (IGameEventListenable<Transform> listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(IGameEventListenable<Transform> listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(IGameEventListenable<Transform> listener) {
            m_Listeners.Remove(listener);
        }
        
        public static TransformGameEvent operator +(TransformGameEvent a, IGameEventListenable<Transform> b) {
            a.AddListener(b);
            return a;
        }
        
        public static TransformGameEvent operator -(TransformGameEvent a, IGameEventListenable<Transform> b) {
            a.RemoveListener(b);
            return a;
        }
    }
}