using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame_Homework.Heroes
{
    // New Added hero
    public class Wizard : Hero
    {
        public Wizard(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
        }

        public override double Defend(double damage)
        {
            double probability = random.NextDouble();
            if (probability < 0.15)
            {

                return HealingAndUntouchable();
            }
            double coef = random.Next(80, 120 + 1);
            double defendPower = (Armor + Weapon.BlockingPower) * (coef / 100);
            double realDamage = damage - defendPower;
            if (realDamage < 0)
                realDamage = 0;
            Health -= realDamage;
            return realDamage;

        }

        private double HealingAndUntouchable()
        {
            Health += 7;
            return 0;


        }


    }
}
