using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public abstract class Duck
    {
        /// <summary>
        /// 飛行的行為
        /// </summary>
        protected IFlyBehavior flyBehavior;
        /// <summary>
        /// 叫的行為
        /// </summary>
        protected IQuackBehavior quackBehavior;

        public abstract void Display();

        /// <summary>
        /// 飛
        /// </summary>
        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        /// <summary>
        /// 叫
        /// </summary>
        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        /// <summary>
        /// 設定飛的行為
        /// </summary>
        /// <param name="behavior"></param>
        public void SetFlyBehavior(IFlyBehavior behavior)
        {
            flyBehavior = behavior;
        }

        /// <summary>
        /// 設定叫的行為
        /// </summary>
        /// <param name="behavior"></param>
        public void SetQuackBehavior(IQuackBehavior behavior)
        {
            quackBehavior = behavior;
        }
    }
}
