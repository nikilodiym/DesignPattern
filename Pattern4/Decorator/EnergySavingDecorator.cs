using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_4.Decorator
{
    public class EnergySavingDecorator : DeviceDecorator
    {
        public EnergySavingDecorator(IDevice device) : base(device) { }

        public override void Operate()
        {
            Console.WriteLine("Activating energy-saving mode...");
            base.Operate();
        }
    }
}
