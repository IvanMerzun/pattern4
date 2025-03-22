﻿using System;
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
        private string _engine = "Diesel";
        private string _wheels = "\"14";

        public Golf()
        {
            _name = "Golf";
            _body = "Hatchback";

        }

        public void AssemblyBody()
        {
            Console.WriteLine("Установка кузов {0}", _body);
        }
        public void AssemblyWheels()
        {
            Console.WriteLine("Установка колес {0}", _wheels);
        }

        public void AssemblyEngine()
        {
            Console.WriteLine("Установка движка {0}", _engine);
        }

        public string GetName()
        {
            return _name;
        }
    }
}
