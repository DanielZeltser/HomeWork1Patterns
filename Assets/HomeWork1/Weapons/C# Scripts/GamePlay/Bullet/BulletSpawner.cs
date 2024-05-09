using UnityEngine;

namespace HomeWork1.Weapons.GamePlay
{
    public sealed class BulletSpawner
    {
        private const float ShotAreaZ = 0.02f;

        private Bullet _bullet;
        private BulletSpawnPoint _bulletSpawnPoint;

        private float RandomPositionZ => Random.Range(-ShotAreaZ, ShotAreaZ);
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
