using System;

namespace InClassExerciseII_Mod4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool takeInput = true;
            string[] validOptions = { "r", "p", "s" };
            string userSelection = "";
            string compSelection = "";
            int compWins = 0;
            int playerWins = 0;
            int roundCount = 0;
            Random rand = new Random();

            Console.WriteLine("Welcome to Rock, Paper, or Scissors.");
            while (takeInput)
            {
                Console.Write("\t\tROUND {0} \nPlease select (r)ock, (p)aper, or (s)cissors : ", roundCount+1);
                userSelection = Console.ReadLine().ToLower();

                if (userSelection != "r" && userSelection != "p" && userSelection != "s")
                {
                    Console.WriteLine("Invalid selection please try again.");
                }
                else
                {
                    takeInput = false;
                }

                compSelection = validOptions[rand.Next(0, validOptions.Length)];
            }

            Console.WriteLine("\tPLAYER: {0} \tvs.\t COMPUTER: {1}", userSelection, compSelection);
            switch (userSelection)
            {
                case "r":
                    if (compSelection == userSelection)
                    {
                        Console.WriteLine("Round was a tie.");
                    }
                    else if (compSelection == "p" )
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
            Console.WriteLine("CURRENT SCORE\n\tPLAYER : {0}\tCOMPUTER : {1}\n", playerWins, compWins);
            Console.Write("Play again? (y or n): ");
            
            Console.ReadKey();
        }
    }
}

