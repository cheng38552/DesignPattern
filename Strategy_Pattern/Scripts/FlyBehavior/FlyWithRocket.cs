using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    /// <summary>
    /// 用火箭飛
    /// </summary>
    public class FlyWithRocket : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("用火箭飛 FlyWithRocket");
        }
    }
}
