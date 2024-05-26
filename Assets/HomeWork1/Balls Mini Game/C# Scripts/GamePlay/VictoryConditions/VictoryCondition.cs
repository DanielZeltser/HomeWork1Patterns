
using System;
using System.Collections.Generic;

namespace HomeWork1.BallsMiniGame.GamePlay
{
    public abstract class VictoryCondition
    {
        protected readonly List<Ball> _balls;

        public abstract event Action Completed;

        public VictoryCondition(List<Ball> balls)
        {
            _balls = balls;

            foreach (Ball ball in balls)
                ball.Touch.Poped += TryComplete;
        }

        protected abstract void TryComplete();

        public void OnDestroy()
        {
            foreach (Ball ball in _balls)
                ball.Touch.Poped -= TryComplete;
        }
    }
}
