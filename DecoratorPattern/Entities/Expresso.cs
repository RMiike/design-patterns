
namespace DecoratorPattern.Entities
{
    class Expresso : Beverage
    {

        string _description = "Expresso";
   
        public override double cost()
        {
            return 1.99;
        }
        public override string getDescription
        {
            get { return _description; }
        }

    }
}
