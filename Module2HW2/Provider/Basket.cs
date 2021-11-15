using System;
using Module2HW2.Config;
using Module2HW2.Model;

namespace Module2HW2.Provider
{
    public class Basket
    {
        private static readonly Basket _instance = new Basket();
        private readonly Device[] _devices;
        private readonly CardConfig _card;

        static Basket()
        {
        }

        private Basket()
        {
            _card = new CardConfig();
            _devices = new Device[_card.Size];
        }

        public static Basket Instance { get => _instance; }

        public void AddBasketItem(Device device)
        {
            for (var i = 0; i < _devices.Length;)
            {
                _devices[i] = device;
                break;
            }
        }

        public void PrintBasket(Device device)
        {
            Console.WriteLine($"{device.Name}--> Price:{device.Price} {device.Type}  Article:{device.Article}");
        }
    }
}
