﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Pattern
{
    class YAMAHA : Motor
    {
        public void Generate()
        {
            Console.WriteLine("Generate YAMAHA_Motor");
        }
    }
}
