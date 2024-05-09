using UnityEngine;

namespace HomeWork1.Weapons.GamePlay
{
    public sealed class GunControl : MonoBehaviour
    {
        [SerializeField] private Gun[] _guns;

        private GunSwitcher _gunSwitcher;

        public void Initialize()
        {
            _gunSwitcher = new GunSwitcher(_guns);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
                SwitchGun();

            if (Input.GetKeyDown(KeyCode.Space))
                OnShoot();
        }

        private void SwitchGun() => _gunSwitcher.SwitchToNext();

        private void OnShoot()
        {
            foreach (Gun gun in _guns)
                if (gun.isActiveAndEnabled)
                    gun.Shoot();
        }
    }
}
