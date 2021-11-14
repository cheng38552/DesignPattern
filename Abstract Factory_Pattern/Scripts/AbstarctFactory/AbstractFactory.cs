using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Pattern
{
    public abstract class AbstractFactory
    {
        public virtual Car GenerateCar(CarType type) => null;
        public virtual Motor GenerateMotor(MotorType type) => null;
    }
}
