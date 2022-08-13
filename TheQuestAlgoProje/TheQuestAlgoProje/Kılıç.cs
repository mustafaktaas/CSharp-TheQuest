using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestAlgoProje
{
    public class Kılıç : Silah
    {
        public Kılıç(Game game, Point location) //yapıcı metod
            : base(game, location) { }

        public override string Name { get { return "Sword"; } }
        public override void Attack(Yön direction, Random random)
        {
            if (!DamageEnemy(direction, 10, 3, random))
            {
                if (!DamageEnemy(ClockwiseDirection(direction), 10, 3, random))
                {
                    DamageEnemy(CounterClockWiseDirection(direction), 10, 3, random);
                }
            }
        }
    }
}
