using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_4.Facade
{
    public class SmartHomeFacade
    {
        private LightingSystem _lightingSystem;
        private ClimateControlSystem _climateControlSystem;
        private SecuritySystem _securitySystem;

        public SmartHomeFacade()
        {
            _lightingSystem = new LightingSystem();
            _climateControlSystem = new ClimateControlSystem();
            _securitySystem = new SecuritySystem();
        }

        public void ActivateAllSystems()
        {
            _lightingSystem.TurnOnLights();
            _climateControlSystem.AdjustTemperature();
            _securitySystem.ActivateSecurity();
        }
    }
}
