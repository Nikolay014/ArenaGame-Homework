using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame_Homework.Weapons
{
    public class Sword : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public double LifeSteal { get; private set; }

        public double CriticalStrike { get; private set; }

        public Sword(string name)
        {
            Name = name;
            AttackDamage = 11;
            BlockingPower = 2;
            LifeSteal = 0.12;
            CriticalStrike = 13;
        }
    }
}
