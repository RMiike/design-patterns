namespace DecoratorPattern.Entities.Decorators
{
    class Milk : CondimentDecorator
    {
        public Beverage _beverage;
        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override double cost()
        {
            return _beverage.cost() + .10;
        }
        public override string getDescription
        {
            get
            {
                return _beverage.getDescription + ", Milk";
            }
        }
    }
}
