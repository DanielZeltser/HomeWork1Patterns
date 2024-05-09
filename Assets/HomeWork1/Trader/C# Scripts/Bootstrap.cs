using HomeWork1.Trader.UI;
using UnityEngine;

namespace HomeWork1.Trader
{
    public sealed class Bootstrap : MonoBehaviour
    {
        [SerializeField] private MoneyView _moneyView;

        private void Awake()
        {
            _moneyView.Initialize();
        }
    }
}
