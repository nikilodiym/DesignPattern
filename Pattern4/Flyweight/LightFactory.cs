using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_4.Flyweight
{
    public class LightFactory
    {
        private Dictionary<string, Light> _lights = new Dictionary<string, Light>();

        public Light GetLight(string color)
        {
            if (!_lights.ContainsKey(color))
            {
                _lights[color] = new Light(color);
            }
            return _lights[color];
        }
    }
}
