using pattern4.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern4.Factory
{
    public class FacilityRussia : Facility
    {
        protected override ICar GetCar()
        {
            return new Tiguan(new CarPartsFactoryRussia());
        }
    }
}
