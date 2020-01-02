

namespace StrategyPatternTwo.Entities
{
    class Knight : Character
    {
        public override void figh()
        {
            _weaponBehavior.useWeapon();

        }
    }
}
