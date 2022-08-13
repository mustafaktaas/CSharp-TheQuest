using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestAlgoProje
{
    public class Hortlak : Düşman, IFSprite
    {
        public Hortlak(Game game, Point location, Size spriteSize)
            : base(game, location, 10, spriteSize) { }

        public override void Move(Random random)
        {
            if (random.Next(1, 3) != 1)
            {
                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }

            if (NearPlayer())
            {
                game.HitPlayer(4, random);
            }
        }
    }
}
