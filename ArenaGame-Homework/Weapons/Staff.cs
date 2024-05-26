using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame_Homework.Weapons
{
    //New Added weapon
    public class Staff : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public double LifeSteal { get; private set; }

        public double CriticalStrike { get; private set; }

        public Staff(string name)
        {
            Name = name;
            AttackDamage = 12;
            BlockingPower = 2;
            LifeSteal = 0.07;
            CriticalStrike = 9;
        }
    }
}
