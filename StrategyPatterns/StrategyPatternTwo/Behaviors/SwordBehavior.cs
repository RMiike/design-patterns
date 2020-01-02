using StrategyPatternTwo.Interfaces;


namespace StrategyPatternTwo.Behaviors
{
    class SwordBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            System.Console.WriteLine("Swing a sword!");
        }
    }
}
