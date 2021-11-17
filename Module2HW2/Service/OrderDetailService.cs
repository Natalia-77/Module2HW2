using System;
namespace Module2HW2.Service
{
    public class OrderDetailService
    {
        private OrderService _orderService;

        public OrderDetailService()
        {
            _orderService = new OrderService();
        }

        public void TotalOrder()
        {
            var total = _orderService.DeviceOrder();
            foreach (var item in total)
            {
                Console.WriteLine($"{item.Name}: {item.Price} {item.Type}");
            }
        }
    }
}
