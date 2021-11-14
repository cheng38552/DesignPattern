using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    /// <summary>
    /// 物品
    /// </summary>
    public interface Item
    {
        string Name();
        Packing packing();
        float price();
    }
}
