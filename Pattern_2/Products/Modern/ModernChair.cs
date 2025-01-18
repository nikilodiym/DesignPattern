using Pattern_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Products.Modern
{
    public class ModernChair : IChair
    {
        public string GetDescription() => "Modern style chair";
    }
}
