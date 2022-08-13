using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestAlgoProje
{
    public abstract class Silah : Hareket
    {
        private bool pickedUp;
        public bool PickedUp { get { return pickedUp; } }

        public Silah(Game game, Point location)
                : base(game, location)
        {
            pickedUp = false;
        }

        public void PickUpWeapon()
        {
            pickedUp = true;
        }

        public abstract string Name { get; }
        public abstract void Attack(Yön direction, Random random);      

        private bool Nearby(Point playerLocation, Düşman enemy, Yön direction, int distance)
        {
            bool isNearby = false;
            Rectangle enemySpriteBoundary = new Rectangle(enemy.Location, enemy.SpriteSize);
            Rectangle playerAttackArea = new Rectangle();

            switch (direction)
            {
                case Yön.Up:
                    playerAttackArea.Location = new Point(playerLocation.X,
                                                          playerLocation.Y
                                                            - distance);
                    playerAttackArea.Width = game.PlayerSpriteSize.Width;
                    playerAttackArea.Height = distance;
                    break;
                case Yön.Right:
                    playerAttackArea.Location = new Point(playerLocation.X
                                                            + game.PlayerSpriteSize.Width,
                                                          playerLocation.Y);
                    playerAttackArea.Width = distance;
                    playerAttackArea.Height = game.PlayerSpriteSize.Height;
                    break;
                case Yön.Down:
                    playerAttackArea.Location = new Point(playerLocation.X,
                                                          playerLocation.Y
                                                            + game.PlayerSpriteSize.Height);
                    playerAttackArea.Width = game.PlayerSpriteSize.Width;
                    playerAttackArea.Height = distance;
                    break;
                case Yön.Left:
                    playerAttackArea.Location = new Point(playerLocation.X
                                                            + distance,
                                                          playerLocation.Y);
                    playerAttackArea.Width = distance;
                    playerAttackArea.Height = game.PlayerSpriteSize.Height;
                    break;
            }

            if (playerAttackArea.IntersectsWith(enemySpriteBoundary))
            {
                isNearby = true;
            }

            return isNearby;
        }

        protected bool DamageEnemy(Yön direction, int radius, int damage, Random random)
        {
            Point playerLocation = game.PlayerLocation;
            foreach (Düşman enemy in game.Enemies)
            {
                if (!enemy.Dead && Nearby(playerLocation, enemy, direction, radius))
                {
                    enemy.Hit(damage, random);
                    return true;
                }
            }
            return false;
        }

        protected Yön ClockwiseDirection(Yön direction)
        {
            Yön clockWiseDirection = direction;

            switch (direction)
            {
                case Yön.Up:
                    clockWiseDirection = Yön.Right;
                    break;
                case Yön.Right:
                    clockWiseDirection = Yön.Down;
                    break;
                case Yön.Down:
                    clockWiseDirection = Yön.Left;
                    break;
                case Yön.Left:
                    clockWiseDirection = Yön.Up;
                    break;
            }

            return clockWiseDirection;
        }

        protected Yön CounterClockWiseDirection(Yön direction)
        {
            Yön counterClockWiseDirection = direction;

            switch (direction)
            {
                case Yön.Up:
                    counterClockWiseDirection = Yön.Left;
                    break;
                case Yön.Right:
                    counterClockWiseDirection = Yön.Up;
                    break;
                case Yön.Down:
                    counterClockWiseDirection = Yön.Right;
                    break;
                case Yön.Left:
                    counterClockWiseDirection = Yön.Down;
                    break;
            }

            return counterClockWiseDirection;
        }
    }
}
