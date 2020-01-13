using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Entities.Decorators
{
    class Whip : CondimentDecorator
    {

        public Beverage _beverage;
        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override double cost()
        {
            return _beverage.cost() + 0.10;
        }

        public override string getDescription()
        {
            return _beverage.description + ", Whip";
        }

    }
}
