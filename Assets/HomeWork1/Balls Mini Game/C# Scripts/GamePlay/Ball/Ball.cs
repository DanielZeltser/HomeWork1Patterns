
using UnityEngine;

namespace HomeWork1.BallsMiniGame.GamePlay
{
    [RequireComponent(typeof(BallTouch))]

    public sealed class Ball : MonoBehaviour
    {
        [field: SerializeField] public BallColors BallColor {  get; private set; }

        public BallTouch Touch { get; private set; }

        public void Initialize()
        {
            Touch = GetComponent<BallTouch>();
        }
    }
}
