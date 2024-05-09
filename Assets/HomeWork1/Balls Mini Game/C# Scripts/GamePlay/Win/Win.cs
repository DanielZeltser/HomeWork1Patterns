using UnityEngine;

namespace HomeWork1.BallsMiniGame.GamePlay
{
    public sealed class Win : MonoBehaviour
    {
        [SerializeField] private WinView _winView;

        private void Start()
        {
            ShowWinView();
        }

        private void ShowWinView() => _winView.gameObject.SetActive(true);
    }
}
