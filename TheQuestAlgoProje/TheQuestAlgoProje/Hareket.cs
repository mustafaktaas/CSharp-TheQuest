using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestAlgoProje
{
    public abstract class Hareket
    {
        private const int MoveInterval = 10;
        protected Point location;

        public Point Location { get { return location; } }
        protected Game game;

        public Hareket(Game game, Point location) 
        {
            this.game = game;
            this.location = location;
        }

        public bool Nearby(Point locationToCheck, int distance)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance &&   //mutlak değer
                Math.Abs(Location.Y - locationToCheck.Y) < distance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Point Move(Yön direction, Rectangle boundaries)
        {
            Point newLocation = location;
            switch (direction)
            {
                case Yön.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                    {
                        newLocation.Y -= MoveInterval;
                    }
                    break;
                case Yön.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                    {
                        newLocation.Y += MoveInterval;
                    }
                    break;
                case Yön.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                    {
                        newLocation.X -= MoveInterval;
                    }
                    break;
                case Yön.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                    {
                        newLocation.X += MoveInterval;
                    }
                    break;
                default: break;
            }
            return newLocation;
        }
    }
}
