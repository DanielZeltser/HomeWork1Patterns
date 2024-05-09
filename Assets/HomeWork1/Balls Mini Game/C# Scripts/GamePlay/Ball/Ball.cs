using UnityEngine;

namespace HomeWork1.BallsMiniGame.GamePlay
{
    public sealed class Ball : MonoBehaviour
    {
        private const float BallPopping = 0.1f;

        [SerializeField] private WinChecker _winChecker;

        public Color MaterialColor { get; private set; }

        public void Initialize()
        {
            MaterialColor = GetComponent<MeshRenderer>().material.color;
        }

        private void OnMouseDown()
        {
            OnPop();
        }

        private void OnPop()
        {
            _winChecker.CheckInDelay(BallPopping);
            Destroy(gameObject);
        }
    }
}
