using Module2HW2.Config;
using Module2HW2.Model;

namespace Module2HW2.Service
{
   public class CartService
    {
        private static readonly CartService _instance = new CartService();
        private Device[] _devices;
        private CardConfig _card;

        static CartService()
        {
        }

        private CartService()
        {
            _card = new CardConfig() { Size = 5 };
            _devices = new Device[_card.Size];
        }

        public static CartService Instance { get => _instance; }

        public void AddBasketItem(Device device)
        {
            for (var i = 0; i < _devices.Length; i++)
            {
                if (_devices[i] == null)
                {
                    _devices[i] = device;
                    break;
                }
            }
        }

        public Device[] GetProducts()
        {
            return _devices;
        }
    }
}
