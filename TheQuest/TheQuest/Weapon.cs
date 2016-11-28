using System;
using System.Drawing;

namespace TheQuest
{
    abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }

        public Weapon(Game game, Point location)
            : base(game, location)
        {
            PickedUp = false;
        }

        public void PickUpWeapon() { PickedUp = true; }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (Nearby(enemy.Location, target, distance))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }

        protected Direction ClockWise(Direction direction)
        {
            Direction clockWiseDirection;
            switch (direction)
            {
                case Direction.Up:
                    clockWiseDirection = Direction.Right;
                    break;
                case Direction.Down:
                    clockWiseDirection = Direction.Left;
                    break;
                case Direction.Left:
                    clockWiseDirection = Direction.Up;
                    break;
                default:
                    clockWiseDirection = Direction.Down;
                    break;
            }
            return clockWiseDirection;
        }

        protected Direction CounterClockWise(Direction direction)
        {
            Direction counterClockWiseDirection;
            switch (direction)
            {
                case Direction.Up:
                    counterClockWiseDirection = Direction.Left;
                    break;
                case Direction.Down:
                    counterClockWiseDirection = Direction.Right;
                    break;
                case Direction.Left:
                    counterClockWiseDirection = Direction.Down;
                    break;
                default:
                    counterClockWiseDirection = Direction.Up;
                    break;
            }
            return counterClockWiseDirection;
        }

        protected Direction Opposite(Direction direction)
        {
            Direction oppositeDirection;
            switch (direction)
            {
                case Direction.Up:
                    oppositeDirection = Direction.Down;
                    break;
                case Direction.Down:
                    oppositeDirection = Direction.Up;
                    break;
                case Direction.Left:
                    oppositeDirection = Direction.Right;
                    break;
                default:
                    oppositeDirection = Direction.Left;
                    break;
            }
            return oppositeDirection;
        }
    }
}
