
namespace DecoratorPattern.Entities
{
    class Decaf : Beverage
    {
        
        public Decaf()
        {
            description = "Decaf";
        }
        public override double cost()
        {
            return 1.05;
        }

        public override string getDescritpion()
        {
            throw new System.NotImplementedException();
        }
    }
}
