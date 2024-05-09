using UnityEngine;

namespace HomeWork1.Trader.GamePlay
{
    public sealed class NoTrade : ITrade
    {
        public void Trade()
        {
            Debug.Log("You don't have enough money for trade");
        }
    }
}
