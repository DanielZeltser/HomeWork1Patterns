using UnityEngine;

namespace HomeWork1.Weapons.GamePlay
{
    [CreateAssetMenu(fileName = "ShotgunConfig", menuName = "Configs/Weapons/Guns/ShotgunConfig")]

    public sealed class ShotgunConfig : ScriptableObject
    {
        [field: SerializeField, Range(0f, 30f)] public int BulletsCount { get; private set; }
        [field: SerializeField, Range(0f, 10f)] public int BulletsCountOnShot { get; private set; }
        [field: SerializeField] public Bullet Bullet { get; private set; }
    }
}
