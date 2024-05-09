using System;
using UnityEngine;

namespace HomeWork1.Weapons.GamePlay
{
    public sealed class Shotgun : Gun 
    {
        [SerializeField] private ShotgunConfig _config;
        [SerializeField] private BulletSpawnPoint _bulletSpawnPoint;

        private int _bulletsCount;
        private BulletSpawner _bulletSpawner;

        public override void Initialize()
        {
            _bulletSpawner = new BulletSpawner(_config.Bullet, _bulletSpawnPoint);
            _bulletsCount = _config.BulletsCount;
        }

        public override void Shoot()
        {
            if (_bulletsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(_bulletsCount));

            for (int value = _config.BulletsCountOnShot; value > 0; value--)
            {
                if (_bulletsCount > 0)
                {
                    _bulletSpawner.RandomSpawn();
                    _bulletsCount -= 1;
                }
            }
        }
    }
}
