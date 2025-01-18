using Pattern_3.Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Builder.Interfaces
{
    public interface IPizzaBuilder
    {
        void Reset();
        void BuildDough();
        void BuildSauce();
        void BuildToppings();
        Pizza GetPizza();
    }
}
