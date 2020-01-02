using StrategyPatternTwo.Interfaces;


namespace StrategyPatternTwo.Behaviors
{
    class KnifwBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            System.Console.WriteLine("Cutting with a knife!");
        }
    }
}
