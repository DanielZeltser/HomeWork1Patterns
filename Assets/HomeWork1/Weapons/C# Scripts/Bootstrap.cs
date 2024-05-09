using HomeWork1.Weapons.GamePlay;
using UnityEngine;

namespace HomeWork1.Weapons
{
    public sealed class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Gun[] _guns;
        [SerializeField] private GunControl _gunControl;

        private void Awake()
        {
            _gunControl.Initialize();

            foreach (Gun gun in _guns)
                gun.Initialize();
        }
    }
}
