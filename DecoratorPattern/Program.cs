using DecoratorPattern.Entities.Decorators;
using DecoratorPattern.Entities;
using System.Globalization;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Beverage beverage = new Expresso();

            System.Console.WriteLine(beverage.getDescription + " $ " + beverage.cost());


            Beverage beverage1 = new DarkRoast();
            System.Console.WriteLine(beverage1.getDescription + " $ " + beverage1.cost());
            beverage1 = new Mocha(beverage1); 
            System.Console.WriteLine(beverage1.getDescription  + " $ "  + beverage1.cost());

             beverage1 = new Milk(beverage1);
            System.Console.WriteLine(beverage1.getDescription  + " $ " + beverage1.cost());

            beverage1 = new Soy(beverage1);

            System.Console.WriteLine(beverage1.getDescription +" $ " +beverage1.cost());
            beverage1 = new Whip(beverage1);

            System.Console.WriteLine(beverage1.getDescription + " $ " + beverage1.cost());

        }
    }
}
