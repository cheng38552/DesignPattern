using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    /// <summary>
    /// 可樂
    /// </summary>
    public class Coke : ColdDrink
    {
        public override string Name()
        {
            return "Coke";
        }

        public override float price()
        {
            return 30.0f;
        }
    }
}
