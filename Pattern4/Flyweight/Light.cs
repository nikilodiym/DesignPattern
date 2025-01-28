using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_4.Flyweight
{
    public class Light
    {
        public string Color { get; private set; }

        public Light(string color)
        {
            Color = color;
        }

        public void Illuminate(string room)
        {
            Console.WriteLine($"Illuminating {room} with {Color} light");
        }
    }
}
