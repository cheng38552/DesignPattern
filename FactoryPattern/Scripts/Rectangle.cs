using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Scripts
{
    public class Rectangle : Shape
    {
        public void Render()
        {
            Console.WriteLine("Render Rectangle");

        }
    }
}
