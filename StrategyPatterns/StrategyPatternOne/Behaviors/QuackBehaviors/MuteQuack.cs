using System;
using StrategyPatternOne.Interface;

namespace StrategyPatternOne.Behaviors.QuackBehaviors
{
    class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
