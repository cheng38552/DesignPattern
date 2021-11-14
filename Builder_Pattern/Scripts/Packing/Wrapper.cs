using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    /// <summary>
    /// 包裝紙
    /// </summary>
    public class Wrapper : Packing
    {
        public string pack()
        {
            return "Wrapper";
        }
    }
}
