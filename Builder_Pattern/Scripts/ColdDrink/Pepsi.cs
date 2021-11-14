using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    /// <summary>
    /// 百事可樂
    /// </summary>
    public class Pepsi : ColdDrink
    {
        public override string Name()
        {
            return "Pepsi";
        }

        public override float price()
        {
            return 35.0f;
        }
    }
}
