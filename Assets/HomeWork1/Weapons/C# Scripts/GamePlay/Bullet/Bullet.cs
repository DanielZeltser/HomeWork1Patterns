using UnityEngine;

namespace HomeWork1.Weapons.GamePlay
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(SphereCollider))]

    public sealed class Bullet : MonoBehaviour
    {
        [SerializeField] private BulletConfig _config;
        [SerializeField] private float _forceShoot;

        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            _rigidbody.AddForce(new Vector3(_forceShoot, 0f, 0f));
            Destroy(gameObject, _config.DestroyDelay);
        }
      
    }
}
