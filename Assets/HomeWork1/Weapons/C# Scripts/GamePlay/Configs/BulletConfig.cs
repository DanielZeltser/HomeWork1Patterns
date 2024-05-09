using UnityEngine;

namespace HomeWork1.Weapons.GamePlay
{
    [CreateAssetMenu(fileName = "BulletConfig", menuName = "Configs/Weapons/BulletConfig")]

    public sealed class BulletConfig : ScriptableObject
    {
       [field: SerializeField, Range(0f,5f)] public float DestroyDelay { get; private set; }
    }
}
