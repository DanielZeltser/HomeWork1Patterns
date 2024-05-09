using UnityEngine;
using TMPro;

namespace HomeWork1.Trader.UI
{
    [RequireComponent(typeof(TextMeshPro))]

    public sealed class MoneyView : MonoBehaviour
    {
        [SerializeField] private string _title;
        [SerializeField] private Money _money;

        private TextMeshPro _view;

        private void OnValidate()
        {
            _view = GetComponent<TextMeshPro>();
            UpdateView();
        }

        public void Initialize()
        {
            _view = GetComponent<TextMeshPro>();
        }

        private void OnEnable()
        {
            _money.UpdatedView += UpdateView;
        }

        private void OnDisable()
        {
            _money.UpdatedView -= UpdateView;
        }

        private void UpdateView() => _view.text = _title + _money.Amount.ToString();
    }
}
