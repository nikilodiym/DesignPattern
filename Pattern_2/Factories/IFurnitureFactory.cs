using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Factories
{
    public class FurnitureShop
    {
        private readonly IFurnitureFactory _factory;

        public FurnitureShop(IFurnitureFactory factory)
        {
            _factory = factory;
        }

        public void CreateFurnitureSet()
        {
            var chair = _factory.CreateChair();
            var sofa = _factory.CreateSofa();
            var coffeeTable = _factory.CreateCoffeeTable();

            Console.WriteLine("Created furniture set:");
            Console.WriteLine(chair.GetDescription());
            Console.WriteLine(sofa.GetDescription());
            Console.WriteLine(coffeeTable.GetDescription());
        }
    }
}
