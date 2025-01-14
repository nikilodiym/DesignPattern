using Pattern_1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_1.Enemies
{
    public class Zombie : Enemy
    {
        public Zombie(Difficulty difficulty)
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    Health = 100;
                    Damage = 10;
                    break;
                case Difficulty.Normal:
                    Health = 150;
                    Damage = 15;
                    break;
                case Difficulty.Hard:
                    Health = 200;
                    Damage = 20;
                    break;
            }
        }

        public override void Attack()
        {
            Console.WriteLine($"Zombie attacks with {Damage} damage!");
        }
    }
}
