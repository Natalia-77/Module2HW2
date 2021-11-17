using Module2HW2.Model;
using Module2HW2.Provider;
namespace Module2HW2.Service
{
   public class DeviceService
    {
        private DeviceProvider _deviceprovider;
        private Device[] _device;

        public DeviceService()
        {
            _deviceprovider = new DeviceProvider();
        }

        public Device[] AllDevices()
        {
            _device = _deviceprovider.ListDevices();
            return _device;
        }
    }
}
