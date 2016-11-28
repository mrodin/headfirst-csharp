using System;
using System.Drawing;

namespace TheQuest
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location)
            : base(game, location, 6)
        { }

        public override void Move(Random random)
        {
            if (!Dead)
            {
                if (random.Next(2) == 0) // 50% chance to move in random direction
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                else
                    location = Move((Direction)random.Next(4), game.Boundaries);
                if (NearPlayer())
                    game.HitPlayer(3, random);
            }
        }
    }
}
