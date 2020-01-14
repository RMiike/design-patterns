namespace DecoratorPattern.Entities
{
    class HouseBlend : Beverage
    {
        string _description = "House Blend";
       
        public override double cost()
        {
            return .89;
        }
        public override string getDescription
        {
            get { return _description; }
        }

    }
}
