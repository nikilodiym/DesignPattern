using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_1.Enemies
{
    public abstract class Enemy
    {
        public int Health { get; protected set; }
        public int Damage { get; protected set; }

        public abstract void Attack();
    }
}
