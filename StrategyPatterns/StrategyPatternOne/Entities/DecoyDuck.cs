using System;
using StrategyPatternOne.Behaviors.FlyBehaviors;
using StrategyPatternOne.Behaviors.QuackBehaviors;

namespace StrategyPatternOne.Entities
{
    class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            _quackBehavior = new MuteQuack();
            _flyBehavior = new FlyNoWay();
        }
        public override void display()
        {
            Console.WriteLine("Decoy Duck");
        }
    }
}
