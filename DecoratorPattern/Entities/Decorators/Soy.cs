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
            return _beverage.cost() + .15;
        }
        public override string getDescription
        {
            get
            {
                return _beverage.getDescription + ", Soy";
            }
        }
    }
}
