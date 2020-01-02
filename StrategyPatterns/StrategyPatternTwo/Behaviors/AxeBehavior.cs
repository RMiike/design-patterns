using StrategyPatternTwo.Interfaces;

namespace StrategyPatternTwo.Behaviors
{
    class AxeBehavior : IWeaponBehavior
    {
       
    public void useWeapon()
        {
            System.Console.WriteLine("Choping with an axe!");
        }
    }
}
