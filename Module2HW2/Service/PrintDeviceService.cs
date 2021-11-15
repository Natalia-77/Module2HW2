using System;
namespace Module2HW2.Service
{
   public class PrintDeviceService
    {
        private DeviceService _devservice;

        public PrintDeviceService()
        {
            _devservice = new DeviceService();
        }

        public void ShowAll()
        {
           var dev = _devservice.AllDevices();
           Console.WriteLine("---All devices in the store:---");
           foreach (var item in dev)
           {
                Console.WriteLine($"{item.Name} {item.Article} -- {item.Price} {item.Type}");
           }
        }
    }
}
