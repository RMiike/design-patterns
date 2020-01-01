using System;
using StrategyPatternOne.Behaviors.FlyBehaviors;
using StrategyPatternOne.Behaviors.QuackBehaviors;

namespace StrategyPatternOne.Entities
{
    internal class MallardDuck : Duck
    {

        public MallardDuck()
        {
            _quackBehavior = new Quack();
            _flyBehavior = new FlyWithWings();
        }
        public override void display()
        {
            Console.WriteLine("Parece um pato bravo!!");
        }
    }
}

