using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Pattern
{
    public class Bmw : Car
    {
        public void Generate()
        {
            Console.WriteLine("Generate BMW_Car");
        }
    }
}
