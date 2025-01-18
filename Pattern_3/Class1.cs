using Pattern_3.Builder.ConcreteBuilders;
using Pattern_3.Builder.Director;
using Pattern_3.Builder.Products;
using Pattern_3.Prototype.ConcretePrototypes;
using Pattern_3.Singleton;

namespace Pattern_3
{
    public class Class1
    {
        static void Main(string[] args)
        {
            var margheritaBuilder = new MargheritaPizzaBuilder();
            var pepperoniBuilder = new PepperoniPizzaBuilder();
            var director = new PizzaDirector(margheritaBuilder);

            director.MakePizza();
            var margheritaPizza = margheritaBuilder.GetPizza();

            director.ChangeBuilder(pepperoniBuilder);
            director.MakePizza();
            var pepperoniPizza = pepperoniBuilder.GetPizza();

            var originalOrder = new Order
            {
                OrderId = 1,
                OrderDate = DateTime.Now,
                Pizzas = new List<Pizza> { margheritaPizza }
            };

            var clonedOrder = (Order)originalOrder.Clone();
            clonedOrder.OrderId = 2;
            clonedOrder.Pizzas.Add(pepperoniPizza);

            var orderManager = OrderManager.Instance;
            orderManager.AddOrder(originalOrder);
            orderManager.AddOrder(clonedOrder);

            Console.WriteLine("All Orders:");
            foreach (var order in orderManager.GetAllOrders())
            {
                Console.WriteLine($"\nOrder #{order.OrderId} - {order.OrderDate}");
                foreach (var pizza in order.Pizzas)
                {
                    Console.WriteLine(pizza.GetDescription());
                }
            }
        }
    }
}
