
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
            return _beverage.cost() + .10;
        }

        public override string getDescription
        {
            get
            {
                return this._beverage.getDescription + ", Whip";
            }
        }

    }
}
