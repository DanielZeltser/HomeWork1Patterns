
using UnityEngine;

namespace HomeWork1.BallsMiniGame.UI
{
    public sealed class UIViewHandler : MonoBehaviour
    {
        [SerializeField] private VictoryView _victoryView;
        [SerializeField] private GameObject _victoryConditionsView;

        public void HideVictoryConditionsView() => _victoryConditionsView.SetActive(false);

        public void ShowVictoryView() => _victoryView.gameObject.SetActive(true);
    }
}