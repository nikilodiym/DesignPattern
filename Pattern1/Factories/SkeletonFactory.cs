using Pattern_1.Enemies;
using Pattern_1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_1.Factories
{
    public class SkeletonFactory : EnemyFactory
    {
        public override Enemy CreateEnemy(Difficulty difficulty)
        {
            return new Skeleton(difficulty);
        }
    }
}
