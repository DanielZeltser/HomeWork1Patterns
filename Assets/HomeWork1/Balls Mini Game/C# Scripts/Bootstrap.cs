
using HomeWork1.BallsMiniGame.GamePlay;
using System.Linq;
using UnityEngine;

namespace HomeWork1.BallsMiniGame
{
    public sealed class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Ball[] _balls;

        private void OnValidate()
        {
            _balls = FindObjectsByType<Ball>(FindObjectsSortMode.InstanceID).ToArray();
        }

        public void Awake()
        {
            foreach (Ball ball in _balls)
                ball.Initialize();
        }
    }
}
