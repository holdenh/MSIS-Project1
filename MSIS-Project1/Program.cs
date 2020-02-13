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
                selection = getUserSelection();
            }
            /* if valid, transplate input to full word selection. */
            if (selection == "r")
            {
                selection = "rock";
            }
            else if (selection == "p")
            {
                selection = "paper";
            }
            else if (selection == "s")
            {
                selection = "scissors";
            }
            else if (selection == "l")
            {
                selection = "lizard";
            }
            else
            {
                selection = "spock";
            }
            return selection;
        }
        /* method that will take two string parameters, and will return the string word "player" or "comp" */
        public static string getRoundWinner(string uSelection, string cSelection)
        {
            string roundWinner = "";
            string compSelectionLower = cSelection.ToLower();
            /* game logic */
            switch (uSelection.ToLower())
            {
                /* Rock beats Scissors/Lizard, and loses to Paper/Spock. */
                case "rock":
                    /* check for winner. */
                    if (compSelectionLower == "scissors" || compSelectionLower == "lizard")
                    {
                        roundWinner = "Player";
                    }
                    else if (compSelectionLower == uSelection.ToLower())
                    {
                        roundWinner = "tie";
                    }
                    else
                    { /* player lost round. */
                        roundWinner = "Computer";
                    }
                    break;
                /* Paper beats Rock/Spock, and loses to Scissors/Lizard */
                case "paper":
                    /* check for winner. */
                    if (compSelectionLower == "rock" || compSelectionLower == "spock")
                    {
                        roundWinner = "Player";
                    }
                    else if (compSelectionLower == uSelection.ToLower())
                    {
                        roundWinner = "tie";
                    }
                    else
                    { /* player lost round. */
                        roundWinner = "Computer";
                    }
                    break;
                /* Scissors beats Paper/Lizard, and loses to Rock/Spock */
                case "scissors":
                    /* check for winner. */
                    if (compSelectionLower == "paper" || compSelectionLower == "lizard")
                    {
                        roundWinner = "Player";
                    }
                    else if (compSelectionLower == uSelection.ToLower())
                    {
                        roundWinner = "tie";
                    }
                    else
                    { /* player lost round. */
                        roundWinner = "Computer";
                    }
                    break;
                /* Lizard beats Paper/Spock, and loses to Rock/Scissors */
                case "lizard":
                    /* check for winner. */
                    if (compSelectionLower == "paper" || compSelectionLower == "spock")
                    {
                        roundWinner = "Player";
                    }
                    else if (compSelectionLower == uSelection.ToLower())
                    {
                        roundWinner = "tie";
                    }
                    else
                    { /* player lost round. */
                        roundWinner = "Computer";
                    }
                    break;
                /* Spockj beats Rock/Scissors, and loses to Paper/Lizard */
                case "spock":
                    /* check for winner. */
                    if (compSelectionLower == "rock" || compSelectionLower == "scissors")
                    {
                        roundWinner = "Player";
                    }
                    else if (compSelectionLower == uSelection.ToLower())
                    {
                        roundWinner = "tie";
                    }
                    else
                    { /* player lost round. */
                        roundWinner = "Computer";
                    }
                    break;
            }

            return roundWinner;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /* variables. */
            bool quit = false;
            string[] selections = { "rock", "paper", "scissors", "lizard", "spock" };
            string uSelection;
            string cSelection;
            int playerWins;
            int compWins;
            int currentRound;
            Random rand = new Random();

            /* play game */
            while (!quit)
            {
                /* Ask user for number of rounds. */
                Console.Write("WELCOME TO ROCK PAPER SCISSOR LIZARD SPOCK!\n\n Would you like to play a best of (1)one, (3)three, or (5)five? : ");
                int numRounds = Convert.ToInt32(Console.ReadLine());
                currentRound = 0;
                Console.Clear();
                while (currentRound < numRounds)
                {
                    /* take user and computer selections */
                    playerWins = 0;
                    compWins = 0;
                    Console.WriteLine("ROUND {0}!\n", currentRound + 1);
                    uSelection = getUserSelection();
                    cSelection = selections[rand.Next(0, selections.Length)];

                    /* find the winner of the round, and add the round point. */
                    string winner = getRoundWinner(uSelection, cSelection);
                    Console.WriteLine("You played {0}. Computer played {1}.", uSelection, cSelection);
                    if (winner == "tie")
                    {
                        Console.WriteLine("This line was a tie.");
                        continue;
                    }
                    else if (winner == "Player")
                    {
                        playerWins++;
                    }
                    else
                    {
                        compWins++;
                    }

                    /* print output and increment round. */
                    Console.WriteLine(winner + " wins round {0}!", currentRound+1);
                    currentRound++;
                }
                /* Ask if play want to retry. */
                Console.Write("Play again(y/Y or anything else for no.)? : ");
                string retry = Console.ReadLine();
                if (retry == "y" || retry == "Y")
                {
                    Console.Clear();
                } 
                else
                {
                    quit = true;
                }
            }
        }
    }
}
