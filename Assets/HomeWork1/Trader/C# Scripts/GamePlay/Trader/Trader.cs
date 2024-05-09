using UnityEngine;

namespace HomeWork1.Trader.GamePlay
{
    [RequireComponent(typeof(Rigidbody))]

    public sealed class Trader : MonoBehaviour
    {
        private ITrade _tradeBehavior;

        private void OnTriggerEnter(Collider other)
        {
            if(other.TryGetComponent(out ICustomer customer))
            {
                if(customer.MoneyAmount == 0)
                    OnTrade(new NoTrade());

                if (customer.MoneyAmount > 0 && customer.MoneyAmount < 3)
                    OnTrade(new FruitsTrade());

                if(customer.MoneyAmount >= 3)
                    OnTrade(new ArmorTrade());
            }
        }

        private void OnTrade(ITrade tradeBehavior)
        {
            _tradeBehavior = tradeBehavior;
            _tradeBehavior.Trade();
        }
    }
}
