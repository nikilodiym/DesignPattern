using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Builder.Products
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();

        public string GetDescription()
        {
            return $"Pizza with {Dough} dough, {Sauce} sauce, and toppings: {string.Join(", ", Toppings)}";
        }
    }
}
