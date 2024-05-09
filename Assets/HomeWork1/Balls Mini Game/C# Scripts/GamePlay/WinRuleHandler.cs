using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace HomeWork1.BallsMiniGame.GamePlay
{
    public sealed class WinRuleHandler
    {
        private readonly List<Color> _ballsColors;
        private readonly List<Color> _materialsColors;
        private readonly List<Ball> _balls;

        public bool AllBallsArePoped { get; private set; }
        public bool OneColorBallsArePoped { get; private set; }

        public WinRuleHandler(List<Ball> balls, List<Color> ballsColors, List<Color> materialsColors , List<Material> materials)
        {
            _balls = balls;
            _ballsColors = ballsColors;
            _materialsColors = materialsColors;

            foreach (Material material in materials)
                 _materialsColors.Add(material.color);
        }

        public void CheckAllBallsArePoped()
        {
            AllBallsArePoped = _balls.All(b => b == null);
        }

        public void CheckOneColorBallsArePoped() //Не смог придумать как реализовать тут Линк
        {
            _ballsColors.Clear();

            foreach (Ball ball in _balls)
                if (ball != null)
                    _ballsColors.Add(ball.MaterialColor);

            foreach (Color materialColor in _materialsColors)
                if (_ballsColors.Contains(materialColor) == false)
                    OneColorBallsArePoped = true;
        }
    }
}
