﻿using System;

namespace MSIS_Project1
{
    class Program
    {
        /* method that asks user for input, and returns a string */
        public static string getUserSelection()
        {
            string selection = "";
            /* take user input */
            Console.Write("(r)ock, (p)aper, (s)cissors, (l)izard, or spoc(k) : ");
            selection = Console.ReadLine();

            /* test whether user input is valid, if not retry user entry. */
            if (selection.ToLower() != "r" && selection.ToLower() != "p" && selection.ToLower() != "s" && selection.ToLower() != "l" 
               && selection.ToLower() != "k")
            {
                getUserSelection();
            }
            return selection;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /* variables. */
            bool stillPlaying = true;
            string uSelection;
            

            /* play game */
            while (stillPlaying)
            {
                uSelection = getUserSelection();
                Console.WriteLine("Player plays {0}\n\n", uSelection);

                /* Ask if play want to retry. */
                Console.Write("Play again? : ");
                string retry = Console.ReadLine();
                if (retry != "y" && retry != "Y")
                {
                    stillPlaying = false;
                }
            }
        }
    }
}
