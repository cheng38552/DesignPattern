using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Scripts
{
    public class Circle : Shape
    {
        public void Render()
        {
            Console.WriteLine("Render Circle");
        }
    }
}
