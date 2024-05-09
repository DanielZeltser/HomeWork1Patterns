using UnityEngine;

namespace HomeWork1.Weapons.GamePlay
{
    public sealed class Blaster : Gun
    {
        [SerializeField] private BlasterConfig _config;
        [SerializeField] private BulletSpawnPoint _bulletSpawnPoint;

        private BulletSpawner _bulletSpawner;

        public override void Initialize()
        {
            _bulletSpawner = new BulletSpawner(_config.Bullet, _bulletSpawnPoint);
        }

        public override void Shoot()
        {
            _bulletSpawner.Spawn();
        }
    }
}
