using System;

namespace InClassExerciseWk16_Mod11
{
    class Program
    {

        public static void Main (string [] args)
        {
            Human h1 = new Human("Varian Wrynn");
            Orc o1 = new Orc("Garrosh Hellscream");
            int round = 1;
            while (o1.current_health > 0 & h1.current_health > 0)
            {
                Console.WriteLine("ROUND {0}\n", round++);
                h1.display();
                Console.WriteLine();
                o1.display();
                Console.WriteLine("\nPress any key to simulate a fighting round. . .\n");
                Console.ReadKey();

                int orc_attack = o1.Attack();
                h1.setCurrHealth(orc_attack);
                int human_attack = h1.Attack();
                o1.setCurrHealth(human_attack);
                Console.WriteLine("Round damage dealt by {0}: \t{1}", h1.name, human_attack);
                Console.WriteLine("Round damage dealt by {0}: \t{1}", o1.name, orc_attack);

                Console.WriteLine("Press any key to continue. . .");
                Console.ReadKey();
                Console.Clear();
            }

            if (o1.current_health > 0 & h1.current_health <= 0)
                Console.WriteLine("{0} wins the fight!!", o1.name);
            else if (h1.current_health > 0 & o1.current_health <= 0)
                Console.WriteLine("{0} wins the fight!!", h1.name);
            else
                Console.WriteLine("Its a tie!!");

            Console.ReadKey();
        }
    }
}
