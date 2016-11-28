using System;
using System.Drawing;

namespace TheQuest
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location)
            : base(game, location)
        { }

        public override string Name
        {
            get { return "Mace"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            if (!DamageEnemy(direction, 20, 7, random))
            {
                if (!DamageEnemy(CounterClockWise(direction), 20, 7, random))
                {
                    if (!DamageEnemy(Opposite(direction), 20, 7, random))
                    {
                        DamageEnemy(ClockWise(direction), 20, 7, random);
                    }
                }
            }
        }
    }
}
