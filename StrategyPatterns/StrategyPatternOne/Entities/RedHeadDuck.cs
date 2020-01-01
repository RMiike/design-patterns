using System;
using StrategyPatternOne.Behaviors.FlyBehaviors;
using StrategyPatternOne.Behaviors.QuackBehaviors;

namespace StrategyPatternOne.Entities
{
    class RedheadDuck : Duck
    {

        public RedheadDuck()
        {
            _quackBehavior = new Quack();
            _flyBehavior = new FlyWithWings();
        }
        public override void display()
        {
            Console.WriteLine("Parece um cabeça-vermelha");
        }
    }
}
