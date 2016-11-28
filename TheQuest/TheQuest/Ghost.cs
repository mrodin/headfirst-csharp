using System;
using System.Drawing;

namespace TheQuest
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location)
            : base(game, location, 8)
        { }

        public override void Move(Random random)
        {
            if (!Dead)
            {
                if (random.Next(3) == 0) // 1 in 3 chance to move in player's direction
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                if (NearPlayer())
                    game.HitPlayer(4, random);
            }
        }
    }
}
