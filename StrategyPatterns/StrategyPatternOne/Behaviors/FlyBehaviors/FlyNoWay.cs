using System;
using StrategyPatternOne.Interface;

namespace StrategyPatternOne.Behaviors.FlyBehaviors
{
    class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("<< I can't fly! >>");
        }
    }
}
