  namespace DecoratorPattern.Entities.Decorators
{
    abstract class CondimentDecorator : Beverage
    {
        string _description = "Abstract Condiment Decorator";
        public override string getDescription
        {
            get { return _description; }
        }
    }
}
