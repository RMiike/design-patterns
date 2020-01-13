using DecoratorPattern.Entities.Decorators;
using DecoratorPattern.Entities;
using System.Globalization;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Beverage beverage = new Espresso();

            System.Console.WriteLine(beverage.getDescritpion() + " $ " + beverage.cost());


            Beverage beverage1 = new DarkRoast();
            System.Console.WriteLine(beverage1.getDescritpion() + " $ " + beverage1.cost());
            beverage1 = new Mocha(beverage1); 
            System.Console.WriteLine(beverage1.getDescritpion() + " $ "  + beverage1.cost());

             beverage1 = new Milk(beverage1);
            beverage1 = new Whip(beverage1);;

            System.Console.WriteLine(beverage1.getDescritpion()+" $ " +beverage1.cost().ToString(CultureInfo.InvariantCulture));
            
        }
    }
}
