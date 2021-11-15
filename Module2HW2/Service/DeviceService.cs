using Module2HW2.Model;
using Module2HW2.Provider;
namespace Module2HW2.Service
{
   public class DeviceService
    {
        private Store _store;
        private Device[] _device;

        public DeviceService()
        {
            _store = new Store();
        }

        public Device[] AllDevices()
        {
            _device = _store.ListDevices();
            return _device;
        }
    }
}
