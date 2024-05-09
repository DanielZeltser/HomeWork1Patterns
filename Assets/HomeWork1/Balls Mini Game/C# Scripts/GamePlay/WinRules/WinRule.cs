using System;
using UnityEngine;

namespace HomeWork1.BallsMiniGame.GamePlay
{
    public class WinRule : MonoBehaviour
    {
        [SerializeField] private GameObject _winRulesView;
        public event Action SettedThisWinRule;

        public virtual void Select()
        {
            Destroy(_winRulesView);
            SettedThisWinRule?.Invoke();
        }
    }
}
