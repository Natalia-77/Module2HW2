using System;
using Module2HW2.Model;
using Module2HW2.Provider;

namespace Module2HW2.Service
{
   public class BasketService
    {
        private Store _store;
        private Device[] _device;
        private Basket _basket;

        public BasketService()
        {
            _store = new Store();
            _device = _store.ListDevices();
            _basket = Basket.Instance;
        }

        public Device AddDevices()
        {
            var rand = new Random();
            var item = _device[rand.Next(0, _device.Length)];
            _basket.AddBasketItem(item);
            return item;
        }
    }
}
