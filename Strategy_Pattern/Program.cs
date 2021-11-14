using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();

            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();

            Console.WriteLine("=======================================");

            RubberDuck rubberDuck = new RubberDuck();

            rubberDuck.Display();
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();

            Console.WriteLine("=======================================");

            ModelDuck modelDuck = new ModelDuck();

            modelDuck.Display();
            modelDuck.PerformFly();
            modelDuck.PerformQuack();

            Console.WriteLine("=======================================");

            Console.WriteLine("將模型鴨改為乘風飛行且吱吱叫");
            modelDuck.SetFlyBehavior(new FlyWithWings());
            modelDuck.SetQuackBehavior(new Squack());

            modelDuck.Display();
            modelDuck.PerformFly();
            modelDuck.PerformQuack();

            Console.ReadKey();
        }
    }
}
