using UnityEngine;

namespace HomeWork1.Weapons.GamePlay
{
    public sealed class BulletSpawner
    {
        private const float MinShotAreaZ = -0.02f;
        private const float MaxShotAreaZ = 0.02f;

        private readonly Bullet _bullet;
        private readonly BulletSpawnPoint _bulletSpawnPoint;

        private float RandomPositionZ => Random.Range(MinShotAreaZ, MaxShotAreaZ);
        private Vector3 BulletSpawnPosition => _bulletSpawnPoint.transform.position;
        private Vector3 BulletRandomSpawnPosition =>
            new (BulletSpawnPosition.x, BulletSpawnPosition.y, BulletSpawnPosition.z + RandomPositionZ);

        public BulletSpawner(Bullet bullet, BulletSpawnPoint bulletSpawnPoint)
        {
            _bullet = bullet;
            _bulletSpawnPoint = bulletSpawnPoint;
        }

        public void Spawn() => Object.Instantiate(_bullet, _bulletSpawnPoint.transform.position, Quaternion.identity);

        public void RandomSpawn() => Object.Instantiate(_bullet, BulletRandomSpawnPosition, Quaternion.identity);
    }
}
