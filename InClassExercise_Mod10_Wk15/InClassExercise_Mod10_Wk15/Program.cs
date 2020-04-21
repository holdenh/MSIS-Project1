using System;

namespace InClassExercise_Mod10_Wk15
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc myOrc = new Orc("Thrall");
            Random rand = new Random();

            int round = 1;
            while (myOrc.getCurrHealth() > 0)
            {
                myOrc.displayInfo();
                Console.WriteLine("ROUND {0}:", round++);

                int oponentDMG = rand.Next(-5, 11);
                Console.WriteLine("Oponent Attacks for: {0}", oponentDMG);
                myOrc.takesDMG(oponentDMG);
                Console.WriteLine("{0}'s current health drops to {1}", myOrc.getName(), myOrc.getCurrHealth());
                Console.WriteLine("{0}'s attack deals : {1}", myOrc.getName(), myOrc.attackMove());

                Console.WriteLine("\n\nPress any key to continue. . .");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Game Over. . . ");
            Console.ReadKey();
        }
    }
}