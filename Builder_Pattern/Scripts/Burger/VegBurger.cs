using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    /// <summary>
    /// 蔬菜漢堡
    /// </summary>
    public class VegBurger : Burger
    {
        public override string Name()
        {
            return "Veg Burger";
        }

        public override float price()
        {
            return 25.0f;
        }
    }
}
