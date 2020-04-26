using System;
using System.Collections.Generic;
using System.Text;

namespace InClassExerciseWk16_Mod11
{
    class Creature
    {
        public static Random rand = new Random();
        public string name { get; set; }
        public string type { get; set; }
        public int base_health { get; set; }
        public int base_attack { get; set; }
        public int current_health { get; set; }

        public Creature () { }
        public Creature (string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public int Attack()
        {
            int attackDMG = base_attack + rand.Next(-5, 6);
            return attackDMG <= 0 ? 0 : attackDMG;
        }
        public void setCurrHealth(int dmg)
        {
            current_health = (current_health - dmg) < 0 ? 0 : current_health - dmg;
        }
        public void display()
        {
            Console.WriteLine("Name: " + name + "\n\tType: " + type + "\n\tAttack: " + base_attack 
                                + "\n\tCur_health: " + current_health);
        }
    }
}
