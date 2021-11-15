using Module2HW2.Model;

namespace Module2HW2.Provider
{
    public class Store
    {
        public Store()
        {
        }

        public Device[] Devices { get; set; }

        public Device[] ListDevices()
        {
            var devices = new[]
            {
                new Device("12R2", "Мобильный телефон Samsung Galaxy M52", 11000, Config.CurrencyType.UAH),
                new Device("13R3", "Мобильный телефон Apple iPhone 11", 21000, Config.CurrencyType.UAH),
                new Device("14R4", "Мобильный телефон Xiaomi Redmi Note 9", 7000, Config.CurrencyType.UAH),
                new Device("15R5", "Мобильный телефон ZTE Blade A51", 3200, Config.CurrencyType.UAH),
                new Device("16R6", "Мобильный телефон OPPO ", 7777, Config.CurrencyType.UAH),
                new Device("17R7", "Мобильный телефон OnePlus 8", 16000, Config.CurrencyType.UAH),
                new Device("18R8", "Мобильный телефон Xiaomi 11 Lite 5G ", 12000, Config.CurrencyType.UAH)
            };
            return devices;
        }
    }
}
