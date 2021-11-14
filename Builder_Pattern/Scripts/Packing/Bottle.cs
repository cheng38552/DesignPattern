using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    /// <summary>
    /// 瓶子
    /// </summary>
    public class Bottle : Packing
    {
        public string pack()
        {
            return "Bottle";
        }
    }
}
