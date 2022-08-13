using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestAlgoProje
{
    public class Maviİksir : Silah, IFIksir
    {
        public Maviİksir(Game game, Point location)
            : base(game, location) { Used = false; }

        public bool Used { get; private set; }

        public override string Name { get { return "Blue Potion"; } }
        public override void Attack(Yön direction, Random random)
        {
            if(!Used)
            {
            game.IncreasePlayerHealth(10, random);
            Used = true;
            }       
        }
    }
}
