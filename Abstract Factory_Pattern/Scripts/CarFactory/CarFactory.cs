using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Pattern
{
    public class CarFactory : AbstractFactory
    {
        public override Car GenerateCar(CarType type)
        {
            switch (type)
            {
                case CarType.Toyota:
                    return new Toyota();
                case CarType.BMW:
                    return new Bmw();
                case CarType.Audi:
                    return new Audi();
                default:
                    return null;
            }
        }
    }
}
