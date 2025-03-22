using pattern4.Factory;
using pattern4.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern4.Car
{
    public class Tiguan : ICar
    {
        private string _name;
        private string _body;

        private Engine _engine;
        private Wheels _wheels;

        private CarPartsFactory _partsFactory;

        public Tiguan(CarPartsFactory partsFactory)
        {
            _name = "Tiguan";
            _body = "Crossover";
            _partsFactory = partsFactory;

        }

        public void AssemblyBody()
        {
            Console.WriteLine("Установка кузов {0}", _body);
        }
        public void AssemblyWheels()
        {
            _wheels = _partsFactory.GetWheels();
        }

        public void AssemblyEngine()
        {
            _engine = _partsFactory.GetEngine();
        }

        public string GetName()
        {
            return _name;
        }
    }
}
