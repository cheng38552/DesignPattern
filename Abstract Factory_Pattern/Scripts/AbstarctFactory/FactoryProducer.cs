using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Pattern
{
    public static class FactoryProducer
    {
        public static AbstractFactory GetFactory(FactoryType type)
        {
            switch (type)
            {
                case FactoryType.Car:
                    return new CarFactory();
                case FactoryType.Motor:
                    return new MotorFactory();
                default:
                    return null;
            }
        }
    }
}
