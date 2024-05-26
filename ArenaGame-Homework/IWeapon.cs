using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame_Homework
{
    public interface IWeapon
    {
        string Name { get; set; }
        double AttackDamage { get; }
        double BlockingPower { get; }

        //Added additional special powers

        //LifeSteal takes a percentage of the attack dealt on the opponent and gives life to the current hero
        double LifeSteal { get; }

        //CriticalStrike is a percentage by which the hero attacks harder on a certain attack.
        double CriticalStrike { get; }

    }
}


