using Pattern_3.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Builder.Director
{
    public class PizzaDirector
    {
        private IPizzaBuilder _builder;

        public PizzaDirector(IPizzaBuilder builder)
        {
            _builder = builder;
        }

        public void ChangeBuilder(IPizzaBuilder builder)
        {
            _builder = builder;
        }

        public void MakePizza()
        {
            _builder.Reset();
            _builder.BuildDough();
            _builder.BuildSauce();
            _builder.BuildToppings();
        }
    }
}
