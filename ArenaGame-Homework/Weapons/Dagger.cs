using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame_Homework.Weapons
{
    public class Dagger : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public double LifeSteal { get; private set; }

        public double CriticalStrike { get; private set; }

        public Dagger(string name)
        {
            Name = name;
            AttackDamage = 10;
            BlockingPower = 3;
            LifeSteal = 0.10;
            CriticalStrike = 11;
        }
    }
}
