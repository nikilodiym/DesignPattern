using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_4.Decorator
{
    public class BasicDevice : IDevice
    {
        public void Operate()
        {
            Console.WriteLine("Device operating normally");
        }
    }
}
