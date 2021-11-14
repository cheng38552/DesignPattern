using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Pattern
{
    public class MotorFactory : AbstractFactory
    {
        public override Motor GenerateMotor(MotorType type)
        {
            switch (type)
            {
                case MotorType.KYMCO:
                    return new Kymco();
                case MotorType.YAMAHA:
                    return new YAMAHA();
                case MotorType.SYM:
                    return new Sym();
                default:
                    return null;
            }
        }
    }
}
