using Module2HW2.Config;

namespace Module2HW2.Model
{
    public class Device
    {
        public Device()
        {
        }

        public Device(string article, string name, decimal price, CurrencyType type)
        {
            Article = article;
            Name = name;
            Price = price;
            Type = type;
        }

        public string Article { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public CurrencyType Type { get; set; }
    }
}
