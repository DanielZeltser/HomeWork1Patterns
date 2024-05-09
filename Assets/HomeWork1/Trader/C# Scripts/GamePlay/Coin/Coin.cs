using UnityEngine;

namespace HomeWork1.Trader.GamePlay
{
    [RequireComponent(typeof(Rigidbody))]

    public sealed class Coin : MonoBehaviour
    {
        [SerializeField, Range(0, 5)] private int _value;

        public int Value => _value;
    }
}
