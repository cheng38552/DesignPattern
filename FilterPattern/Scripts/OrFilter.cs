using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_Pattern
{
    public class OrFilter : Filter
    {
        List<Filter> filters;
        public OrFilter(params Filter[] filters)
        {
            this.filters = new List<Filter>();
            if(filters != null) Array.ForEach(filters, filter => this.filters.Add(filter));
        }
        public string this[string str]
        {
            get
            {
                filters?.ForEach(filter => str = filter[str]);
                return str;
            }
        }
    }
}
