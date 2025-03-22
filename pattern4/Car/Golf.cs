using pattern4.Factory;
using pattern4.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern4.Car
{
    public class Golf : ICar
    {
        private string _name;
        private string _body;

        private Engine _engine;
        private Wheels _wheels;

        private CarPartsFactory _partsFactory;

        public Golf(CarPartsFactory partsFactory)
        {
            _name = "Golf";
            _body = "Hatchback";
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
