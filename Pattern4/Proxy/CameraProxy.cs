using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_4.Proxy
{
    public class CameraProxy : ICamera
    {
        private RealCamera _realCamera;

        public CameraProxy()
        {
            _realCamera = new RealCamera();
        }

        public void ShowVideo()
        {
            Console.WriteLine("Authenticating user..");
            _realCamera.ShowVideo();
        }
    }
}
