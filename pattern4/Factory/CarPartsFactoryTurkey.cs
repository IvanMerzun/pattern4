using pattern4.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern4.Factory
{
    public class CarPartsFactoryTurkey : CarPartsFactory
    {
        public Engine GetEngine()
        {
            return new GasolineEngine();
        }

        public Wheels GetWheels()
        {
            return new CityWheels();
        }
    }
}
