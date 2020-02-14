using System;

namespace InClassExerciseI_Mod3
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            int userInput;            
            int firstNum;
            int secNum;
            bool notSwapped = true;


            while (notSwapped)
            {
                // take user input.
                Console.Write("Please enter a two-digit integer: ");
                userInput = Convert.ToInt32(Console.ReadLine());

                // Part One
                if (userInput <= 0)
                {
                    Console.WriteLine("\nInvalid input! Please enter a positive integer.\n");
                } //Part Two
                else if (Convert.ToString(userInput).Length < 2 || Convert.ToString(userInput).Length > 2)
                {
                    Console.WriteLine("\nCalculation overloaded! Please enter a two-digit number.\n");
                }
                else
                {
                    // perform swap
                    firstNum = userInput / 10;        // moves decimal one place, so return first digit of two-digit num

                    secNum = userInput % 10;          // modulus return the remainder, which is the second digit in our case.
                    notSwapped = false;
                    // show output.
                    Console.WriteLine("\nThe mirrored number of " + userInput + " is " + secNum + firstNum);
                    Console.WriteLine("\nSwap Complete. Press enter to exit.");
                    Console.ReadKey();
                }
            }
        }
    }
}
