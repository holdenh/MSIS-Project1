using System;

namespace InClassExerciseII_Mod4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* variables */
            bool takeInput = true;
            string[] validOptions = { "r", "p", "s" };
            string userSelection = "";
            string compSelection = "";
            int compWins = 0;
            int playerWins = 0;
            int roundCount = 0;
            Random rand = new Random();

            Console.WriteLine("Welcome to Rock, Paper, or Scissors.");

            /* wrap entire game- user selections, comp selection rand generation, and game logic - into a while loop. */
            while (takeInput)
            {
                /* Display the round number, and ask the user for their selection.  */
                Console.Write("\n\t\tROUND {0} \nPlease select (r)ock, (p)aper, or (s)cissors : ", roundCount + 1);
                userSelection = Console.ReadLine().ToLower();

                if (userSelection != "r" && userSelection != "p" && userSelection != "s")
                {
                    Console.WriteLine("Invalid selection please try again.");
                }
                else
                {
                    takeInput = false;
                }

                /* after user enters a valid selections, calculate the computers random variable. */
                compSelection = validOptions[rand.Next(0, validOptions.Length)];


                /* Display the round match, then decide who has won. */
                Console.WriteLine("\tPLAYER: {0} \tvs.\t COMPUTER: {1}", userSelection, compSelection);
                switch (userSelection)
                {
                    case "r":
                        if (compSelection == userSelection)
                        {
                            Console.WriteLine("Round was a tie.");
                        }
                        else if (compSelection == "p")
                        {
                            Console.WriteLine("Computer won this round!");
                            compWins++;
                        }
                        else
                        {
                            Console.WriteLine("Player wins this round!");
                            playerWins++;
                        }
                        break;
                    case "p":
                        if (compSelection == userSelection)
                        {
                            Console.WriteLine("Round was a tie.");
                        }
                        else if (compSelection == "s")
                        {
                            Console.WriteLine("Computer won this round!");
                            compWins++;
                        }
                        else
                        {
                            Console.WriteLine("Player wins this round!");
                            playerWins++;
                        }
                        break;
                    case "s":
                        if (compSelection == userSelection)
                        {
                            Console.WriteLine("Round was a tie.");
                        }
                        else if (compSelection == "r")
                        {
                            Console.WriteLine("Computer won this round!");
                            compWins++;
                        }
                        else
                        {
                            Console.WriteLine("Player wins this round!");
                            playerWins++;
                        }
                        break;
                } // end switch.

                /* display the current score, and ask the user if they would like to play another round. */
                Console.WriteLine("CURRENT SCORE\n\tPLAYER : {0}\tCOMPUTER : {1}\n", playerWins, compWins);
                Console.Write("Play again? (y or n): ");
                string playAgain = Console.ReadLine();
                if (playAgain == "y")
                {
                    takeInput = true;
                }
                roundCount++;
            }
        }
    }
}

