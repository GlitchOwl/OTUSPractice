using Scripts;
using UnityEngine;

namespace Core
{
    public class BulletShooter : MonoBehaviour
    {
        [SerializeField] private Transform spawnPoint;

        [SerializeField] private Bullet bullet;

        public void Shoot()
        {
            var o = Instantiate(bullet, spawnPoint.position, Quaternion.identity).gameObject;
            Destroy(o, 5f);
        }
    }
}