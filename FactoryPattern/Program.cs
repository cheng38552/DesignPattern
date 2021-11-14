using FactoryPattern.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //建立一個工廠
            ShapeFactory factory = new ShapeFactory();
            //向工廠取得Circle
            factory[ShapeType.Circle].Render();
            //向工廠取得Rectangle
            factory[ShapeType.Rectangle].Render();
            //向工廠取得Square
            factory[ShapeType.Square].Render();

            Console.ReadKey();
        }
    }
}
