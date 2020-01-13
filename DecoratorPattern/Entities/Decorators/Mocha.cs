using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Entities.Decorators
{
    class Mocha : CondimentDecorator
            {

        public Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double cost()
        {
            return _beverage.cost() + .20;
        }

        public override string getDescription()
        {
            return _beverage.description + ", Mocha";
        }

      
    }
}
