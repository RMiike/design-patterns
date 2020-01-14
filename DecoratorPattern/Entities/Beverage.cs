
namespace DecoratorPattern.Entities
{
    abstract class Beverage
    {


        private string _description = "Unknown Beverage";
  

    
        public  virtual string getDescription
        {
            get { return _description; } 
        }

        public abstract double cost();

       
    }
}
