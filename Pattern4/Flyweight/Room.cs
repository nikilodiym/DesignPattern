using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_4.Flyweight
{
    public class Room
    {
        private Light _light;

        public Room(string color, LightFactory factory)
        {
            _light = factory.GetLight(color);
        }

        public void Illuminate()
        {
            _light.Illuminate("Room");
        }
    }
}
