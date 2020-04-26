using System;
using System.Collections.Generic;
using System.Text;

namespace InClassExerciseWk16_Mod11
{
    class Orc: Creature
    {
        public Orc(string name)
        {
            this.name = name;
            type = "orc";
            base_attack = rand.Next(10, 16);
            base_health = rand.Next(45, 71);
            current_health = base_health;
        }
        public int Attack()
        {
            int rage = rand.Next(0, 11);
            int attackDMG = base_attack + rage;
            Console.WriteLine("{0} takes {1} rage dmg", name, rage)
;            setCurrHealth(rage);    // takeDMG() method.curhealth - rage;
            return attackDMG <= 0 ? 0 : attackDMG;
        }
    }
}
