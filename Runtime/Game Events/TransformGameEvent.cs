// Generated script for BazzaGibbs.GameEvents package

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Transform GameEvent", fileName = "NewTransformEvent", order = 3)]
    public class TransformGameEvent : ScriptableObject {
        private HashSet<TransformGameEventListener> m_Listeners = new();
        
        public void Invoke(Transform val) {
            foreach (TransformGameEventListener listener in m_Listeners) {
                listener.Invoke(val);
            }
        }
        
        public void AddListener(TransformGameEventListener listener) {
            m_Listeners.Add(listener);
        }
        
        public void RemoveListener(TransformGameEventListener listener) {
            m_Listeners.Remove(listener);
        }
        
        public static TransformGameEvent operator +(TransformGameEvent a, TransformGameEventListener b) {
            a.AddListener(b);
            return a;
        }
        
        public static TransformGameEvent operator -(TransformGameEvent a, TransformGameEventListener b) {
            a.RemoveListener(b);
            return a;
        }
    }
}