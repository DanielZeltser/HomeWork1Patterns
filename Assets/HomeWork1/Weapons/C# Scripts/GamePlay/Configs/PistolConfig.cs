using UnityEngine;

namespace HomeWork1.Weapons.GamePlay
{
    [CreateAssetMenu(fileName = "PistolConfig", menuName = "Configs/Weapons/Guns/PistolConfig")]

    public sealed class PistolConfig : ScriptableObject
    {
        [field: SerializeField, Range(0f, 50f)] public int BulletsCount { get; private set; }
        [field: SerializeField, Range(0f, 3f)] public int BulletsCountOnShot { get; private set; }
        [field: SerializeField] public Bullet Bullet { get; private set; }
    }
}
