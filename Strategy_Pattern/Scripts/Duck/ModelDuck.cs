using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    /// <summary>
    /// 模型鴨
    /// </summary>
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyWithRocket();
            quackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("ModelDuck 模型鴨");
        }
    }
}
