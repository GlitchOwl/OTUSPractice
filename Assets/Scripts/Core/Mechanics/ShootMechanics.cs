using Elementary;
using UnityEngine;

namespace Core.Mechanics
{
    [RequireComponent(typeof(BulletShooter))]
    public class ShootMechanics : MonoBehaviour
    {
        [SerializeField] private EventReceiver shootReceiver;

        [SerializeField] private BulletShooter shooter;

        private void OnEnable()
        {
            shootReceiver.OnEvent += Shoot;
        }

        private void OnDisable()
        {
            shootReceiver.OnEvent -= Shoot;
        }


        private void Shoot()
        {
            shooter.Shoot();
        }
    }
}