using HomeWork1.Trader.UI;
using UnityEngine;

namespace HomeWork1.Trader.GamePlay
{
    [RequireComponent(typeof(Rigidbody))]

    public sealed class Player : MonoBehaviour, ICustomer
    {
        [SerializeField] private Money _money;

        public int MoneyAmount => _money.Amount;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Coin coin))
                _money.Add(coin.Value);
        }
    }
}
