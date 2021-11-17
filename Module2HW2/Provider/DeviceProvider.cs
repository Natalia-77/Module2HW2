using Module2HW2.Model;

namespace Module2HW2.Provider
{
    public class DeviceProvider
    {
        public DeviceProvider()
        {
        }

        public Device[] Devices { get; set; }

        public Device[] ListDevices()
        {
            var devices = new[]
            {
                new Device()
                {
                    Id = 1,
                    Article = "12R2",
                    Name = "Мобильный телефон Samsung Galaxy M52",
                    Price = 11000,
                    Type = Config.CurrencyType.UAH
                },
                new Device()
                {
                    Id = 2,
                    Article = "13R3",
                    Name = "Мобильный телефон Apple iPhone 11",
                    Price = 21000,
                    Type = Config.CurrencyType.UAH
                },
                new Device()
                {
                    Id = 3,
                    Article = "14R4",
                    Name = "Мобильный телефон Xiaomi Redmi Note 9",
                    Price = 7000,
                    Type = Config.CurrencyType.UAH
                },
                new Device()
                {
                    Id = 5,
                    Article = "15R2",
                    Name = "Мобильный телефон ZTE Blade A51",
                    Price = 3200,
                    Type = Config.CurrencyType.UAH
                }
            };
            return devices;
        }
    }
}
