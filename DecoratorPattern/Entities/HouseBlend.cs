namespace DecoratorPattern.Entities
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend";
        }
        public override double cost()
        {
            return .89;
        }

        public override string getDescritpion()
        {
            throw new System.NotImplementedException();
        }
    }
}
