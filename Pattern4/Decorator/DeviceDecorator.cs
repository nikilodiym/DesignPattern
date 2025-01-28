using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_4.Decorator
{
    public abstract class DeviceDecorator : IDevice
    {
        protected IDevice _device;

        public DeviceDecorator(IDevice device)
        {
            _device = device;
        }

        public virtual void Operate()
        {
            _device.Operate();
        }
    }
}
