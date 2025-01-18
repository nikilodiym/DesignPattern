using Pattern_2.Factories;

namespace Pattern_2
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Creating modern furniture set...");
            var modernShop = new FurnitureShop(new ModernFurnitureFactory());
            modernShop.CreateFurnitureSet();

            Console.WriteLine();

            Console.WriteLine("Creating victorian furniture set...");
            var victorianShop = new FurnitureShop(new VictorianFurnitureFactory());
            victorianShop.CreateFurnitureSet();
        }
    }
}
