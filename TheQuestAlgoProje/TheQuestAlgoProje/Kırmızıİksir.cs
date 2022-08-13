using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestAlgoProje
{
    public class Kırmızıİksir : Silah, IFIksir
    {
        public Kırmızıİksir(Game game, Point location)
            : base(game, location) { Used = false; }

        public bool Used { get; private set; }

        public override string Name { get { return "Red Potion"; } }
        public override void Attack(Yön direction, Random random)
        {
            if(!Used)
            {
            game.IncreasePlayerHealth(15, random);
            Used = true;
            }         
        }
    }
}
