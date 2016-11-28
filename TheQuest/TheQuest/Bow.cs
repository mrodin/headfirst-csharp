using System;
using System.Drawing;

namespace TheQuest
{
    class Bow : Weapon
    {
        public Bow(Game game, Point location)
            : base(game, location)
        { }

        public override string Name
        {
            get { return "Bow"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(direction, 30, 1, random);
        }
    }
}
