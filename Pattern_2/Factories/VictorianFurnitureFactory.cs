using Pattern_2.Interfaces;
using Pattern_2.Products.Victorian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Factories
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new VictorianChair();
        public ISofa CreateSofa() => new VictorianSofa();
        public ICoffeeTable CreateCoffeeTable() => new VictorianCoffeeTable();
    }
}
