using StrategyPatternTwo.Interfaces;


namespace StrategyPatternTwo.Behaviors
{
    class BowAndArrowBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            System.Console.WriteLine("Shooting with an arrow!");
        }
    }
}
