using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    /// <summary>
    /// 冷飲類
    /// </summary>
    public abstract class ColdDrink : Item
    {
        public abstract string Name();

        public Packing packing()
        {
            return new Bottle();
        }

        public abstract float price();
    }
}
