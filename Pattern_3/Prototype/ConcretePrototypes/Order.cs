using Pattern_3.Builder.Products;
using Pattern_3.Prototype.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Prototype.ConcretePrototypes
{
    public class Order : IOrderPrototype
    {
        public int OrderId { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public DateTime OrderDate { get; set; }

        public Order()
        {
            Pizzas = new List<Pizza>();
        }

        public IOrderPrototype Clone()
        {
            Order clonedOrder = new Order
            {
                OrderId = this.OrderId,
                OrderDate = this.OrderDate,
                Pizzas = new List<Pizza>(this.Pizzas)
            };
            return clonedOrder;
        }
    }
}
