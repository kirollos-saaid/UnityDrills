using System;
using UnityEngine;
using UnityEngine.UI;

namespace Health
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private Slider slider;
        [SerializeField] private Health health;

        private void Start()
        {
            health.OnDamage += HealthOnOnDamage;
            health.OnDeath += HealthOnOnDeath;
        }

        private void HealthOnOnDeath()
        {
            slider.gameObject.SetActive(false);
        }

        private void HealthOnOnDamage(int obj)
        {
            slider.value = obj / (float)health.MaxHealth;
        }
    }
}