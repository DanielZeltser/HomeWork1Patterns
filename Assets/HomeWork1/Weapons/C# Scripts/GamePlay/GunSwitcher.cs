
namespace HomeWork1.Weapons.GamePlay
{
    public sealed class GunSwitcher
    {
        private int _index = 0;
        private Gun[] _guns;

        public GunSwitcher(Gun[] guns)
        {
            _guns = guns;
        }

        public void SwitchToNext()
        {
            DisableCurrentGun();
            EnableNextGun();
        }

        private void DisableCurrentGun() => _guns[_index].gameObject.SetActive(false);

        private void EnableNextGun() //Не смог придумать более элегантную реализацию
        {
            _index++;
            if (_index == _guns.Length)
                _index = 0;

            _guns[_index].gameObject.SetActive(true);
        }
    }

}
