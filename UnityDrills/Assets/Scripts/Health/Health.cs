using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Health
{
    public class Health : MonoBehaviour
    {
        [FormerlySerializedAs("_maxHealth")] [SerializeField] private int maxHealth = 100;

        public int MaxHealth => maxHealth;
        public event Action<int> OnDamage;
        public event Action OnDeath;

        private int _currentHealth;

        private void Start()
        {
            _currentHealth = maxHealth;
        }

        public void TakeDamage(int damage)
        {
            _currentHealth -= damage;
            if (_currentHealth <= 0)
            {
                OnDeath?.Invoke();
            }
            else
            {
                OnDamage?.Invoke(_currentHealth);
            }
        }
    }
}