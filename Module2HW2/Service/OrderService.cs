using System;
using Module2HW2.Config;
using Module2HW2.Model;
using Module2HW2.Provider;

namespace Module2HW2.Service
{
    public class OrderService
    {
        private DeviceProvider _deviceprovider;
        private Device[] _device;
        private CartService _cartService;
        private CardConfig _cardConfig;

        public OrderService()
        {
            _deviceprovider = new DeviceProvider();
            _device = _deviceprovider.ListDevices();
            _cartService = CartService.Instance;
            _cardConfig = new CardConfig() { Size = 5 };
        }

        public void AddDevices()
        {
            for (int i = 0; i < _cardConfig.Size; i++)
            {
                var rand = new Random();
                var item = _device[rand.Next(0, _device.Length)];
                _cartService.AddBasketItem(item);
            }
        }

        public Device[] DeviceOrder()
        {
            var result = _cartService.GetProducts();
            return result;
        }
    }
}
