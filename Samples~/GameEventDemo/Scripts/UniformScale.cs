using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents.Demo {
    public class UniformScale : MonoBehaviour {
        [SerializeField] private float m_MinScale = 1.0f;
        [SerializeField] private float m_MaxScale = 5.0f;

        public void SetScale(float t) {
            float targetScale = Mathf.Lerp(m_MinScale, m_MaxScale, t);
            transform.localScale = new Vector3(targetScale, targetScale, targetScale);
        }
    }
}
