﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern4.Car
{
    public interface ICar
    {
        string GetName();
        void AssemblyBody();
        void AssemblyEngine();
        void AssemblyWheels();

    }
}
