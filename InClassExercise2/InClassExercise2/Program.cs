using System;

namespace InClassExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            int userInt;            // use strings for second solution. 
            int firstNum;
            int secNum;

            // take user input.
            Console.Write("Please enter a two-digit integer: ");
            userInt = Convert.ToInt32(Console.ReadLine());
            //userInt = Console.ReadLine();
            //char [] numbers = userInt.ToCharArray();

            // perform swap
            firstNum = userInt / 10;        // moves decimal one place, so return first digit of two-digit num
            //firstNum = numbers[0].ToString();
            secNum = userInt % 10;          // modulus return the remainder, which is the second digit in our case.
            //secNum = numbers[1].ToString();

            // show output.
            Console.WriteLine("\nThe mirrored number of " + userInt + " is " + secNum + firstNum);

            Console.ReadKey();

            
        }
    }
}
