using Module2HW2.Provider;
using Module2HW2.Service;
namespace Module2HW2
{
    public class Starter
    {
        private OrderService _orderService;
        private EmailService _emailService;
        private DeviceService _deviceService;
        private OrderDetailService _orderdetailService;
        private UserProvider _user;

        public Starter()
        {
            _orderService = new OrderService();
            _emailService = new EmailService();
            _deviceService = new DeviceService();
            _orderdetailService = new OrderDetailService();
            _user = new UserProvider();
        }

        public void Run()
        {
            _deviceService.AllDevices();
            _user.SetUser();
            _orderService.AddDevices();
            _emailService.EmailInfo(_user.SetUser());
            _orderdetailService.TotalOrder();
        }
    }
}
