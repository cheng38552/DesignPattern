using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "a-s=d-f=q-w=e-r=z-x=c-v";
            Console.WriteLine("Origin:" + message);
            //Ans: a-s=d-f=q-w=e-r=z-x=c-v

            Console.WriteLine("Filter(=):" + new EqualFilter()[message]);
            //過濾掉'='
            //Ans: a-sd-fq-we-rz-xc-v

            Console.WriteLine("Filter(-):" + new MinusFilter()[message]);
            //過濾掉'-'
            //Ans: as=df=qw=er=zx=cv

            Console.WriteLine("Filter(-,=):" + new OrFilter(new EqualFilter(), new MinusFilter())[message]);
            //過濾掉'='and "-"
            //Ans: asdfqwerzxcv

            Console.ReadKey();
        }
    }
}
