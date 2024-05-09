using System;
using UnityEngine;

namespace HomeWork1.Trader.UI
{
    public sealed class Money : MonoBehaviour
    {
        public int Amount { get; private set; }

        public event Action UpdatedView;

        public void Add(int value)
        {
            Amount += value;
            UpdatedView?.Invoke();
        }
    }
}
