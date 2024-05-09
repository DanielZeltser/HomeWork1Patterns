using HomeWork1.BallsMiniGame.GamePlay;
using System.Collections.Generic;
using UnityEngine;

namespace HomeWork1.BallsMiniGame
{
    public sealed class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Ball[] _balls;
        [SerializeField] private WinChecker _winCheker;

        private void OnValidate()
        {
            _balls = FindObjectsByType<Ball>(FindObjectsSortMode.InstanceID);
        }

        private void Awake()
        {
            _winCheker.Initialize(new List<Color>(), new List<Color>());

            foreach (Ball ball in _balls) 
                ball.Initialize();
        }
    }
}
