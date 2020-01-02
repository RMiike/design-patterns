

namespace StrategyPatternTwo.Entities
{
    class King : Character
    {
        public override void figh()
        {
            _weaponBehavior.useWeapon();
        }
      
    }
}
