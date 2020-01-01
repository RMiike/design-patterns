using System;
using StrategyPatternOne.Behaviors.FlyBehaviors;
using StrategyPatternOne.Behaviors.QuackBehaviors;

namespace StrategyPatternOne.Entities
{
    class ModelDuck : Duck
    {

        public ModelDuck()
        {
            _quackBehavior = new Quack();
            _flyBehavior = new FlyRocketPowered();
        }
        public override void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
