using UnityEngine;

namespace HomeWork1.Trader.GamePlay
{
    public sealed class FruitsTrade : ITrade
    {
        public void Trade()
        {
            Debug.Log("I have fresh fruits for you !");
        }
    }
}
