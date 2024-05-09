using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace HomeWork1.BallsMiniGame.GamePlay
{
    public sealed class WinChecker : MonoBehaviour
    {
        [SerializeField] private List<Ball> _balls;
        [SerializeField] private List<Material> _materials;
        [SerializeField] private Win _win;

        [Header("WinRules")]
        [SerializeField] private PopOneColor _popOneColor;
        [SerializeField] private PopAllBalls _popAllBalls;

        private WinRuleHandler _winRuleHandler;

        public bool IsCheckPopOneColor { get; private set; }
        public bool IsCheckPopAllBalls { get; private set; }

        private void OnValidate() => _balls = FindObjectsByType<Ball>(FindObjectsSortMode.InstanceID).ToList();

        private void OnEnable()
        {
            _popAllBalls.SettedThisWinRule += SetWinRulePopAllBalls;
            _popOneColor.SettedThisWinRule += SetWinRulePopOneColor;
        }

        private void OnDisable()
        {
            _popAllBalls.SettedThisWinRule -= SetWinRulePopAllBalls;
            _popOneColor.SettedThisWinRule -= SetWinRulePopOneColor;
        }

        public void Initialize(List<Color> ballsColors, List<Color> materialsColors)
        {
            _winRuleHandler = new WinRuleHandler(_balls, ballsColors, materialsColors, _materials);
        }

        public void CheckInDelay(float delay)
        {
            Invoke(nameof(Check), delay);
        }

        public void SetWinRulePopAllBalls() => IsCheckPopAllBalls = true;
        public void SetWinRulePopOneColor() => IsCheckPopOneColor = true;

        private void Check()
        {
            if (IsCheckPopOneColor)
            {
                _winRuleHandler.CheckOneColorBallsArePoped();
                _win.enabled = _winRuleHandler.OneColorBallsArePoped;
            }

            if (IsCheckPopAllBalls)
            {
                _winRuleHandler.CheckAllBallsArePoped();
                _win.enabled = _winRuleHandler.AllBallsArePoped;
            }
        }
    }
}
