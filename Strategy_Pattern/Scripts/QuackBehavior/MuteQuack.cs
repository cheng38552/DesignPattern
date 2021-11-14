using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    /// <summary>
    /// 不能叫
    /// </summary>
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("不能叫 QuackNoWay");
        }
    }
}
