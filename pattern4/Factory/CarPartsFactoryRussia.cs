using pattern4.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern4.Factory
{
    class CarPartsFactoryRussia : CarPartsFactory
    {
        public Engine GetEngine()
        {
            return new DiselEngine();
        }

        public Wheels GetWheels()
        {
            return new HighwayWheels();
        }
    }
}
