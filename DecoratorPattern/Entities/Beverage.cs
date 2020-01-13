
namespace DecoratorPattern.Entities
{
    abstract class Beverage
    {


        public string description = "Unknown Beverage ";
  

    
        public virtual string getDescritpion()
        {
            return description; 
        }

        public abstract double cost();

       
    }
}
