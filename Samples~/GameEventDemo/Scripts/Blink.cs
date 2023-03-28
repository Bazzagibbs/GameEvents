using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BazzaGibbs.GameEvents.Demo{
    public class Blink : MonoBehaviour {
        [SerializeField] private Color m_BlinkColor = Color.red;
        [SerializeField] private float m_BlinkTime = 0.5f;

        private Material m_Material;
        private Color m_OriginalColor;
        private IEnumerator m_BlinkCoroutine;
        
        private void Start() {
            m_Material = GetComponent<MeshRenderer>().material;
            m_OriginalColor = m_Material.color;
        }

        public void PerformBlink() {
            if (m_BlinkCoroutine != null) {
                StopCoroutine(m_BlinkCoroutine);
            }

            StartCoroutine(PerformBlinkCoroutine());
        }

        private IEnumerator PerformBlinkCoroutine() {
            m_Material.color = m_BlinkColor;
            yield return new WaitForSeconds(m_BlinkTime);
            m_Material.color = m_OriginalColor;
        }
    }
}