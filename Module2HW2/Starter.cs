using Module2HW2.Model;
using Module2HW2.Service;
namespace Module2HW2
{
    public class Starter
    {
        private PrintDeviceService _deviceService;
        private PrintOrderService _order;
        private OrderService _orderService;
        private EmailService _emailService;
        private User _user;

        public Starter()
        {
            _deviceService = new PrintDeviceService();
            _order = new PrintOrderService();
            _orderService = new OrderService();
            _emailService = new EmailService();
            _user = new User();
        }

        public void Run()
        {
            _deviceService.ShowAll();
            _order.PrintOrder();
            _orderService.OrderInfo(_user);
            _emailService.EmailAccept(_user);
            _orderService.OrderFinish(_user);
        }
    }
}
