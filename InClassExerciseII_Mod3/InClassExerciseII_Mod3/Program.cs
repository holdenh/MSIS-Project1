using System;

namespace InClassExerciseII_Mod3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compute random int
            Random rand = new Random();
            int rNum = rand.Next(1, 101);
            Console.WriteLine("Hello, welcome to the number gaame! \nI have have "+ rNum);
            Console.WriteLine("To win, you need to enter another number. And the additin should be divisible by both 2 and 3. \nSo what is your number");

            // take user input
            int uNum = Convert.ToInt32(Console.ReadLine());

            // Do calculation
            int result = rNum + uNum;
            
            // check result.
            if (result % 2 == 0 & result % 3 == 0)
            {
                Console.WriteLine("You win!");
            }
            else if (result % 2 == 0 && result % 3 != 0 || result % 2 != 0 && result % 3 == 0)
            {
                Console.WriteLine("It is a tie");
            }
            else
            {
                Console.WriteLine("Computer wins :(");
            }

            Console.ReadKey();
        }
    }
}
