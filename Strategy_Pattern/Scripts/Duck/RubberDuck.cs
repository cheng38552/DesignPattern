using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    /// <summary>
    /// 橡皮鴨
    /// </summary>
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squack();
        }
        public override void Display()
        {
            Console.WriteLine("RubberDuck 橡皮鴨");
        }
    }
}
