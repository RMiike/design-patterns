using System;
using StrategyPatternOne.Interface;

namespace StrategyPatternOne.Behaviors.FlyBehaviors
{
    class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("<< I'm flying!! >>");
        }
    }
}
