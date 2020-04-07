using System;
using System.Collections.Generic;

namespace InClassExerciseMod9_Wk14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<string> orcNames = new List<string> { "Thrall", "Durotan", "Garrosh", "Gul'dan" };
            List<Orc> battleGroup = new List<Orc>();
            // create a single orc
            Orc orc1 = new Orc("Holden");

            orc1.displayInfo();
            orc1.takesDMG(rand.Next(0,11));    // could do 0 dmg or max, 10 dmg.
            orc1.displayInfo();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\nCREATING A GROUP OF ORCS\n");

            //create a new orc for each name in the list, and add to the battlegroup.
            foreach(string name in orcNames)
            {
                Orc newOrc = new Orc(name);
                battleGroup.Add(newOrc);
            }

            // for each orc in the battlegroup, display their current info.
            foreach(Orc orc in battleGroup)
            {
                orc.displayInfo();
            }

            Console.ReadKey();
        }
    }
}
