using System;
using StrategyPatternOne.Interface;

namespace StrategyPatternOne.Behaviors.QuackBehaviors
{
    class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< Squeak >>");
        }
    }
}
