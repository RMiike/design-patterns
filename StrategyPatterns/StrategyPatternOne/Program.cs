using StrategyPatternOne.Entities;

namespace StrategyPatternOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Duck mallard = new MallardDuck();
            mallard.swim();
            mallard.display();
            mallard.performFly();
            mallard.performQuack();
            Duck model = new ModelDuck();
            model.performFly();

        }
    }
}
