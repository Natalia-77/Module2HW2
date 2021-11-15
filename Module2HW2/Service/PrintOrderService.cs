using System;
using Module2HW2.Config;
using Module2HW2.Provider;

namespace Module2HW2.Service
{
    public class PrintOrderService
    {
        private CardConfig _card;
        private BasketService _basketService;
        private Basket _basket;

        public PrintOrderService()
        {
            _card = new CardConfig();
            _basketService = new BasketService();
            _basket = Basket.Instance;
        }

        public void PrintOrder()
        {
            Console.WriteLine("---Customer order:---");
            for (var i = 0; i < _card.Size; i++)
            {
                var order = _basketService.AddDevices();
                _basket.PrintBasket(order);
            }
        }
    }
}
