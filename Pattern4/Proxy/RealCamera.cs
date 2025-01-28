using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_4.Proxy
{
    public class RealCamera : ICamera
    {
        public void ShowVideo()
        {
            Console.WriteLine("Streaming video from the real camera..");
        }
    }
}
