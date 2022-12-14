using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestAlgoProje
{
    public class Topuz : Silah
    {
        public Topuz(Game game, Point location)
            : base(game, location) { }

        public override string Name { get { return "Mace"; } }
        public override void Attack(Yön direction, Random random)
        {
            if (!DamageEnemy(direction, 20, 6, random))
            {
                Yön nextAttackDirection = CounterClockWiseDirection(direction);
                for (int i = 0; i < 3; i++)
                {
                    if (DamageEnemy(nextAttackDirection, 20, 6, random))
                    {
                        break;
                    }
                    nextAttackDirection = CounterClockWiseDirection(direction);
                }
            }
        }
    }
}
