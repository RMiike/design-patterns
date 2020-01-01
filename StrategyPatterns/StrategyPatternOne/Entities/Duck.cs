using System;
using StrategyPatternOne.Interface;

namespace StrategyPatternOne.Entities
{
    abstract class Duck
    {

        public IQuackBehavior _quackBehavior;
        public IFlyBehavior _flyBehavior;


        public Duck()
        {

        }
        public abstract void display();

        public void performQuack()
        {
            _quackBehavior.quack();

        }
        public void performFly()
        {
            _flyBehavior.fly();
        }
        public void setFlyBehavior(IFlyBehavior fb)
        {
            _flyBehavior = fb;
        }
        public void setQuackBehavior(IQuackBehavior qb)
        {
            _quackBehavior = qb;
        }
        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
