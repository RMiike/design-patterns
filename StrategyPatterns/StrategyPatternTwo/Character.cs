using StrategyPatternTwo.Entities;
using StrategyPatternTwo.Interfaces;


namespace StrategyPatternTwo
{
    abstract class Character
    {

        public IWeaponBehavior _weaponBehavior;

        public Character()
        {

        }

        public abstract void figh();

        public void setWeapon(IWeaponBehavior weaponBehavior)
        {
            this._weaponBehavior = weaponBehavior;
        }

    }
}
