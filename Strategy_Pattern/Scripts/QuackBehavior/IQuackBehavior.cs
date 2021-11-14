using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    /// <summary>
    /// 叫的行為
    /// </summary>
    public interface IQuackBehavior
    {
        void Quack();
    }
}
