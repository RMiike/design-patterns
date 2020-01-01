using System;
using StrategyPatternOne.Behaviors.FlyBehaviors;
using StrategyPatternOne.Behaviors.QuackBehaviors;

namespace StrategyPatternOne.Entities
{
    class RubberDuck : Duck
    {

        public RubberDuck()
        {
            _quackBehavior = new Squeak();
            _flyBehavior = new FlyNoWay();
        }

        public override void display()
        {
            Console.WriteLine("Rubber duck");
        }
    }
}
