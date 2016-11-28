using System;
using System.Drawing;

namespace TheQuest
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location)
            : base(game, location)
        { }

        public override string Name
        {
            get { return "Sword"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            if (!DamageEnemy(direction, 10, 4, random))
            {
                if (!DamageEnemy(ClockWise(direction), 10, 4, random))
                {
                    DamageEnemy(CounterClockWise(direction), 10, 4, random);
                }
            }
        }
    }
}
