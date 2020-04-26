using System;
using System.Collections.Generic;
using System.Text;

namespace InClassExerciseWk16_Mod11
{
    class Human: Creature
    {
        public int med_count { get; set; }
        public Human(string name) 
        {
            this.name = name;
            type = "human";
            base_attack = rand.Next(5, 11);
            base_health = rand.Next(30, 51);
            med_count = rand.Next(3, 9);
            current_health = base_health;
        }
        public void heal()
        {
            if (med_count > 0)
            {
                int health = rand.Next(5, 11);
                current_health += health;
                med_count--;
                Console.WriteLine("{0} took some medicinem and is healed for {1}", name, health);
            }
            else
            {
                Console.WriteLine("No Medicine left.");
            }
        }

        public int Attack()
        {
            int attackDMG = base_attack + rand.Next(-7, 4);
            if (rand.Next(0,2) == 0) { heal(); }
            return attackDMG <= 0 ? 0 : attackDMG;
        }
        public void display()
        {
            Console.WriteLine("Name: {0}\n\tType: {1}\n\tMed_Count : {2}\n\tAttack: {3}\n\tCur_Health: {4}", name, type, med_count, base_attack, current_health );
        }
    }
}
