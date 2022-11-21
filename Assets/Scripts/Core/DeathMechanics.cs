using System;
using Elementary;
using UnityEngine;

namespace Core
{
    public class DeathMechanics : MonoBehaviour
    {
        [SerializeField] private IntBehaviour hitPoints;

        [SerializeField] private EventReceiver deathReceiver;

        private void OnEnable()
        {
            hitPoints.OnValueChanged += OnDeath;
        }

        private void OnDisable()
        {
            hitPoints.OnValueChanged -= OnDeath;
        }

        private void OnDeath(int updatedHitPoints)
        {
            if (updatedHitPoints <= 0)
            {
                deathReceiver.Call();
                Debug.LogWarning($"Died");
            }
        }
    }
}