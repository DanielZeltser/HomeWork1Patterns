
using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace HomeWork1.BallsMiniGame.GamePlay
{
    public class BallTouch : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        public event Action Poped;

        public void OnPointerDown(PointerEventData eventData) { }

        public void OnPointerUp(PointerEventData eventData)
        {
            Pop();
            Poped?.Invoke();
        }

        private void Pop() => gameObject.SetActive(false);
    }
}