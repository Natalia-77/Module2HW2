using Module2HW2.Config;

namespace Module2HW2.Model
{
    public class Device
    {
        public int Id { get; set; }
        public string Article { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public CurrencyType Type { get; set; }
    }
}
