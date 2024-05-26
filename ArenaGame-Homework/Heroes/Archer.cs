using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame_Homework.Heroes
{
    //New Added hero
    public class Archer : Hero
    {
        public Archer(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
        }

        public override double Attack()
        {
            double probability = random.NextDouble();
            if (probability < 0.18)
            {
                return Headshot();
            }
            return base.Attack();
        }

        private double Headshot()
        {
            return base.Attack() * 2;
        }
    }
}

