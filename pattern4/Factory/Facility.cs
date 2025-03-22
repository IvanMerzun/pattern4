using pattern4.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern4.Factory
{
    public abstract class Facility
    {
        protected abstract ICar GetCar();

        public ICar BuildCar()
        {
            var car = GetCar();
            Console.WriteLine("Создание машины {0}", car.GetName());
            car.AssemblyBody();
            car.AssemblyWheels();
            car.AssemblyEngine();
            return car;
        }
    }
}
