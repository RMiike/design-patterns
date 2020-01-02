using StrategyPatternTwo.Entities;
using StrategyPatternTwo.Interfaces;
using StrategyPatternTwo.Behaviors;

namespace StrategyPatternTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Character queen = new Queen();
            queen.setWeapon(new BowAndArrowBehavior()) ;
            queen.figh();
            Character king = new King();
            king.setWeapon(new AxeBehavior());
            king.figh();
            Character knight = new Knight();
            knight.setWeapon(new SwordBehavior());
            knight.figh();
            Character troll = new Troll();
            troll.setWeapon(new KnifwBehavior());
            troll.figh();
        }
    }
}
