using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    /// <summary>
    /// 吱吱叫
    /// </summary>
    public class Squack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("吱吱叫 Squack! Squack!");
        }
    }
}
