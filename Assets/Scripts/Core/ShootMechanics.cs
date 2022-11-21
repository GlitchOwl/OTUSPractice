using Elementary;
using Scripts;
using UnityEngine;

namespace Core
{
    public class ShootMechanics : MonoBehaviour
    {
        [SerializeField] private EventReceiver shootReceiver;

        [SerializeField] private Transform spawnPoint;

        [SerializeField] private Bullet bullet;

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
            Destroy(Instantiate(bullet, spawnPoint.position, Quaternion.identity).gameObject, 5f);
        }
    }
}