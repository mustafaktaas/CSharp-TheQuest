using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestAlgoProje
{
    public class Yay : Silah
    {
        public Yay(Game game, Point location)
            : base(game, location) { }

        public override string Name { get { return "Bow"; } }
        public override void Attack(Yön direction, Random random)
        {
            DamageEnemy(direction, 30, 2, random);
        }
    }
}
