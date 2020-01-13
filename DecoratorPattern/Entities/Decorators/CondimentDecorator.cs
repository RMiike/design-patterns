using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Entities.Decorators
{
    abstract class CondimentDecorator : Beverage
    {
        public abstract  string getDescription();
      
    }
}
