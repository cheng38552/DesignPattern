using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_Pattern
{
    public interface Filter
    {
        string this[string str] { get;}
    }
}
