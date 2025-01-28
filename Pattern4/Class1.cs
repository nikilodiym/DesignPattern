using Pattern_4.Decorator;
using Pattern_4.Facade;
using Pattern_4.Flyweight;
using Pattern_4.Proxy;

namespace Pattern4
{
    public class Class1
    {
        static void Main(string[] args)
        {
            IDevice basicDevice = new BasicDevice();
            IDevice energySavingDevice = new EnergySavingDecorator(basicDevice);
            energySavingDevice.Operate();

            SmartHomeFacade facade = new SmartHomeFacade();
            facade.ActivateAllSystems();

            ICamera camera = new CameraProxy();
            camera.ShowVideo();

            LightFactory lightFactory = new LightFactory();
            Room room1 = new Room("Warm White", lightFactory);
            Room room2 = new Room("Cool White", lightFactory);
            room1.Illuminate();
            room2.Illuminate();
        }
    }
}
