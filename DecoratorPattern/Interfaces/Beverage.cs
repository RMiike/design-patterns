
namespace DecoratorPattern.Interfaces
{
    abstract class Beverage
    {
        private string description = "Unknown Beverage";

        public string getDescritpion()
        {
            return description;
        }

        public abstract void cost();
    }
}
