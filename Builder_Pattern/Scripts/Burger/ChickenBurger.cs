using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    /// <summary>
    /// 雞肉漢堡
    /// </summary>
    public class ChickenBurger : Burger
    {
        public override string Name()
        {
            return "Chicken Burger";
        }

        public override float price()
        {
            return 50.0f;
        }
    }
}
