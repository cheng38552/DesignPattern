using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFactory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var carFactory = FactoryProducer.GetFactory(FactoryType.Car);

            carFactory.GenerateCar(CarType.Toyota).Generate();
            carFactory.GenerateCar(CarType.BMW).Generate();
            carFactory.GenerateCar(CarType.Audi).Generate();

            var motorFactory = FactoryProducer.GetFactory(FactoryType.Motor);

            motorFactory.GenerateMotor(MotorType.KYMCO).Generate();
            motorFactory.GenerateMotor(MotorType.SYM).Generate();
            motorFactory.GenerateMotor(MotorType.YAMAHA).Generate();

            Console.ReadKey();
        }
    }
}
