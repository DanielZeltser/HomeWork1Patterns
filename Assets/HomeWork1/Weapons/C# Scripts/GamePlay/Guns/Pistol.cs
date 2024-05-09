using System;
using UnityEngine;

namespace HomeWork1.Weapons.GamePlay
{
    public sealed class Pistol : Gun
    {
        [SerializeField] private PistolConfig _config;
        [SerializeField] private BulletSpawnPoint _bulletSpawnPoint;

        private int _bulletsCount;
        private BulletSpawner _bulletSpawner;

        private bool PistolHasBullets => _bulletsCount > 0;

        public override void Initialize()
        {
            _bulletSpawner = new BulletSpawner(_config.Bullet, _bulletSpawnPoint);
            _bulletsCount = _config.BulletsCount;
        }

        public override void Shoot()
        {
            if (_bulletsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(_bulletsCount));

            if (PistolHasBullets)
            {
                _bulletSpawner.Spawn();
                _bulletsCount -= _config.BulletsCountOnShot;
            }
        }
    }
}
