using Pattern_1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_1.Enemies
{
    public class Skeleton : Enemy
    {
        public Skeleton(Difficulty difficulty)
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    Health = 80;
                    Damage = 15;
                    break;
                case Difficulty.Normal:
                    Health = 120;
                    Damage = 20;
                    break;
                case Difficulty.Hard:
                    Health = 160;
                    Damage = 25;
                    break;
            }
        }

        public override void Attack()
        {
            Console.WriteLine($"Skeleton shoots arrow with {Damage} damage!");
        }
    }
}
