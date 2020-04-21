using System;
using System.Collections.Generic;
using System.Text;

namespace InClassExercise_Mod10_Wk15
{
    class Orc
    {
        // variables
        private string name;
        private int baseHealth;
        private int currHealth;
        private int attackDamage;
        private Random rand;

        // Constructor
        public Orc(string name)
        {
            rand = new Random();
            this.name = name;
            baseHealth = rand.Next(10, 41);     // 10-40
            currHealth = baseHealth;
            attackDamage = rand.Next(1, 9);     // 1-8
        }

        // Function that will handle the orc's attacking.
        public int attackMove()
        {
            int dmg = (getAttackDMG() + rand.Next(-6, 7));
            return dmg < 0 ? 0 : dmg;
        }
        // helper functions for adding and removing health.
        public void takesDMG(int dmg)
        {
            if (dmg > 0)
            {
                Console.WriteLine("{0} takes {1} dmg. . .", name, dmg);
                setCurrHealth(currHealth - dmg);
            }
            else
            {
                Console.WriteLine("{0} takes 0 dmg. . .", name);
            }
        }
        public void getsHealed(int hp)
        {
            setCurrHealth(currHealth + hp);
        }
        // set the orc's currentHealth to a specific amount.
        public void setCurrHealth(int health)
        {
            currHealth = health;
        }
        public int getCurrHealth()

        {
            return currHealth;
        }
        // getters and setters for the rest of the variables, will be used if we need access outside of this class.
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setBaseHealth(int health)
        {
            baseHealth = health;
        }
        public int getBaseHealth()
        {
            return baseHealth;
        }
        public void setAttackDMG(int dmg)
        {
            attackDamage = dmg;
        }
        public int getAttackDMG()
        {
            return attackDamage;
        }
        public void displayInfo()
        {
            Console.Write("Orc Name : {0}\n\tBase Health : {1}\n\tCurrent Health : {2}\n\tAttack DMG : {3}\n\n", name, baseHealth, currHealth, attackDamage);
        }
    }
}
