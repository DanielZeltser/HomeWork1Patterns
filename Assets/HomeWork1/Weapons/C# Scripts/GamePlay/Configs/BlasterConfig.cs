using UnityEngine;

namespace HomeWork1.Weapons.GamePlay
{
    [CreateAssetMenu(fileName = "BlasterConfig", menuName = "Configs/Weapons/Guns/BlasterConfig")]

    public sealed class BlasterConfig : ScriptableObject
    {
        [field: SerializeField] public Bullet Bullet { get; private set; }
    }
}
