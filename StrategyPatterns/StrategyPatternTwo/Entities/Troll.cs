
namespace StrategyPatternTwo.Entities
{
    class Troll : Character
    {
        public override void figh()
        {
            _weaponBehavior.useWeapon();
        }
    }
}
