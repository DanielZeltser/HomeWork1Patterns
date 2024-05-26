
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork1.BallsMiniGame.GamePlay
{
    public sealed class PopAllBalls : VictoryCondition
    {
        public override event Action Completed;

        public PopAllBalls(List<Ball> balls) : base(balls)
        {
            
        }

        protected override void TryComplete()
        {
            if (_balls.All(b => b.isActiveAndEnabled == false))
                Completed?.Invoke();
        }
    }
}
