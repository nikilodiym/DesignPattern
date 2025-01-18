using Pattern_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Products.Victorian
{
    public class VictorianChair : IChair
    {
        public string GetDescription() => "Victorian style chair";
    }
}
