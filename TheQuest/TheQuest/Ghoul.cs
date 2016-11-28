using System;
using System.Drawing;

namespace TheQuest
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
            : base(game, location, 10)
        { }

        public override void Move(Random random)
        {
            if (!Dead)
            {
                if (random.Next(3) != 0) // 2 in 3 chance to move in player's direction
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                if (NearPlayer())
                    game.HitPlayer(5, random);
            }
        }
    }
}
