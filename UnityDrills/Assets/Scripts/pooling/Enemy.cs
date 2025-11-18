using System;
using System.Collections;
using UnityEngine;

namespace pooling
{
    public class Enemy : MonoBehaviour
    {
        private float _lifeSpan = 5.0f;
        private Action _onDeath;

        public void Init(Action onDeath)
        {
            _onDeath = onDeath;
            StartCoroutine(Dead());
        }
        
        private IEnumerator Dead()
        {
            yield return new WaitForSeconds(_lifeSpan);
            _onDeath?.Invoke();
        }
    }
}