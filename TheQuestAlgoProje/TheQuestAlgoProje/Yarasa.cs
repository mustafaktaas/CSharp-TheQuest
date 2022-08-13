using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestAlgoProje
{
    public class Yarasa : Düşman
    {
        public Yarasa(Game game, Point location, Size spriteSize)
            : base(game, location, 6, spriteSize) { }

        public override void Move(Random random)
        {
            if (random.Next(1, 2) == 1)
            {
                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }
            else
            {
                location = Move((Yön)random.Next(1, 4), game.Boundaries);
            }
            if (NearPlayer())
            {
                game.HitPlayer(2, random);
            }
        }
    }
}
