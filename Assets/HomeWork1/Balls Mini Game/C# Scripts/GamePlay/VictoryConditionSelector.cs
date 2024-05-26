
using HomeWork1.BallsMiniGame.UI;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace HomeWork1.BallsMiniGame.GamePlay
{
    //
    // Is calling in Buttons in OnClick()
    //

    public sealed class VictoryConditionSelector : MonoBehaviour
    {
        [SerializeField] private UIViewHandler _uiViewHandler;

        [SerializeField] private List<Ball> _balls;
        [SerializeField] private List<BallColors> _allBallColors;

        private VictoryCondition _victoryCondition;

        private void OnValidate()
        {
            _balls = FindObjectsByType<Ball>(FindObjectsSortMode.InstanceID).ToList();
        } 

        private void OnDestroy()
        {
            _victoryCondition.Completed -= _uiViewHandler.ShowVictoryView;
            _victoryCondition.OnDestroy();
        }

        public void SelectPopAllBalls()
        {
            _victoryCondition = new PopAllBalls(_balls);
            OnSelect();
        }

        public void SelectPopOneColor()
        {
            _victoryCondition = new PopOneColor(_balls, new List<BallColors>(), _allBallColors);
            OnSelect();
        }

        private void OnSelect()
        {
            _victoryCondition.Completed += _uiViewHandler.ShowVictoryView;

            _uiViewHandler.HideVictoryConditionsView();
        }
    }
}