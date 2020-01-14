namespace DecoratorPattern.Entities.Decorators
{
    class Mocha : CondimentDecorator
            {
        Beverage _beverage;
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override double cost()
        {
            return _beverage.cost() + .20;
        }
        public override string getDescription
        {
            get
            {
                return _beverage.getDescription + ", Mocha";
            }
        }
    }
}
