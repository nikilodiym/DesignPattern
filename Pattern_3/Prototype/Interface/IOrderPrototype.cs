using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Prototype.Interface
{
    public interface IOrderPrototype
    {
        IOrderPrototype Clone();
    }
}
