namespace DecoratorPattern.Entities
{
    class Decaf : Beverage
    {
        string _description = "Decaf";
        public override double cost()
        {
            return 1.05;
        }
        public override string getDescription
        {
            get { return _description; }
        }
    }
}
