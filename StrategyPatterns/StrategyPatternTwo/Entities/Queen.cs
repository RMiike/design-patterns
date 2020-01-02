

namespace StrategyPatternTwo.Entities
{
    class Queen : Character
    {
        public override void figh()
        {
            _weaponBehavior.useWeapon();
        }
    }
}
