using Pattern_3.Builder.Interfaces;
using Pattern_3.Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Builder.ConcreteBuilders
{
    public class PepperoniPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public void Reset()
        {
            _pizza = new Pizza();
        }

        public void BuildDough()
        {
            _pizza.Dough = "Thick";
        }

        public void BuildSauce()
        {
            _pizza.Sauce = "Spicy Tomato";
        }

        public void BuildToppings()
        {
            _pizza.Toppings.Add("Pepperoni");
            _pizza.Toppings.Add("Mozzarella");
            _pizza.Toppings.Add("Oregano");
        }

        public Pizza GetPizza()
        {
            Pizza result = _pizza;
            Reset();
            return result;
        }
    }
}
