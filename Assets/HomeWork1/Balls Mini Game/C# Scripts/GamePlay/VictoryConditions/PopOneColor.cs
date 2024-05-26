
using System;
using System.Collections.Generic;

namespace HomeWork1.BallsMiniGame.GamePlay
{
    public sealed class PopOneColor : VictoryCondition
    {
        private readonly List<BallColors> _ballsColors;
        private readonly List<BallColors> _allBallColors;

        public override event Action Completed;

        public PopOneColor(List<Ball> balls, List<BallColors> ballsColor, List<BallColors> allBallColors) : base (balls)
        {
            _ballsColors = ballsColor;
            _allBallColors = allBallColors;
        }

        protected override void TryComplete()
        {
            _ballsColors.Clear();

            foreach (Ball ball in _balls)
                if (ball.isActiveAndEnabled)
                    _ballsColors.Add(ball.BallColor);

            foreach (BallColors color in _allBallColors)
                if (_ballsColors.Contains(color) == false)
                    Completed?.Invoke();
        }
    }
}
