using System;
using StrategyPatternOne.Interface;

namespace StrategyPatternOne.Behaviors.QuackBehaviors
{
    class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< Quack >>");
        }
    }
}
