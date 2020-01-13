

namespace DecoratorPattern.Entities
{
    class DarkRoast : Beverage
    {
    
      
        public override double cost()
        {
            return .99;
        }

        public override string getDescritpion()
        {
             return "Dark Roast Café"; 
        }
    }
}
