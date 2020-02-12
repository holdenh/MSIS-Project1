using System;

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
        /* method that will take two string parameters, and will return the string word "player" or "comp" */
        public static string getRoundWinner(string uSelection, string cSelection)
        {
            string roundWinner = "";

            /* game logic */
            switch (uSelection.ToLower())
            {
                case "p":
                    break;
                case "r":
                    break;
                case "s":
                    break;
                case "l":
                    break;
                case "k":
                    break;
                default :
            }

            return roundWinner;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /* variables. */
            bool stillPlaying = true;
            string[] options = { "r", "p", "s", "l", "k" };
            string uSelection;
            string cSelection;
            Random rand = new Random();

            /* play game */
            while (stillPlaying)
            {
                /* take user and computer selections */
                uSelection = getUserSelection();
                Console.WriteLine("Player plays {0}", uSelection);
                cSelection = options[rand.Next(0, options.Length)];
                Console.WriteLine("Computer plays {0}\n\n", cSelection);

                /* find the winner of the round, given the selections. */
                string winner = getRoundWinner(uSelection, cSelection);

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
