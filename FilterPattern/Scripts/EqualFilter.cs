using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_Pattern
{
    public class EqualFilter : Filter
    {
        public string this[string str]
        {
            get
            {
                var strs = str.Split('=');
                string newStr = string.Empty;
                Array.ForEach(strs, oldstr => newStr += oldstr);
                return newStr;
            }
        }
    }
}
