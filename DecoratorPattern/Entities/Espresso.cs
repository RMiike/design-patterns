
namespace DecoratorPattern.Entities
{
    class Espresso : Beverage
    {

        public Espresso()
        {
           

        }

        public override double cost()
        {
            return 1.99;
        }

        public override string getDescritpion()
        {
            return "Expresso";
        }
    }
}
