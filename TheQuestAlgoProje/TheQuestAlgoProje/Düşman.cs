using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestAlgoProje
{
    public abstract class Düşman : Hareket, IFSprite  {
        private const int NearPlayerDistance = 25;
        private int hitPoints;

        public int HitPoints { get { return hitPoints; } }
        public Size SpriteSize { get; private set; }

        public bool Dead
        {
            get
            {
                if (hitPoints <= 0) return true;
                else return false;
            }
        }

        public Düşman(Game game, Point location, int hitPoints, Size spriteSize)
                : base(game, location)
        {
            this.hitPoints = hitPoints;
            SpriteSize = spriteSize;
        }

        public abstract void Move(Random random);

        public void Hit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage);
        }

        protected bool NearPlayer() 
        {
            return Nearby(game.PlayerLocation, NearPlayerDistance);
        }

        protected Yön FindPlayerDirection(Point playerLocation)
        {
            Yön directionToMove;
            if (playerLocation.X > location.X + 10) directionToMove = Yön.Right;
            else if (playerLocation.X < location.X - 10) directionToMove = Yön.Left;
            else if (playerLocation.Y < location.Y - 10) directionToMove = Yön.Up;
            else directionToMove = Yön.Down;

            return directionToMove;
        }
    }
}
