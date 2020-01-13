using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Entities.Decorators
{
    class Soy : CondimentDecorator
    {

        public Beverage _beverage;
        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double cost()
        {
            return _beverage.cost() +  0.15;
        }

        public override string getDescription()
        {
            return _beverage.getDescritpion() + ", Soy";
        }

        public override string getDescritpion()
        {
            throw new NotImplementedException();
        }
    }
}
