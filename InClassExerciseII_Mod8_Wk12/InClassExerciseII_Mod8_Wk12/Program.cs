using System;
using System.Collections.Generic;

/**
 *      Holden Halferty
 *      Week 12 Attendance 4/2/2020
 *      
 *      Create a small DBMS that makes use of methods to create a Dictionary of students
 *          and display some information about the students.
 */

namespace InClassExerciseII_Mod8_Wk12
{
    class Program
    {
        /* Function that is called that display different use options. */
        static void displayMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Build the playground.");
            Console.WriteLine("2) Display all students.");
            Console.WriteLine("3) Display one student.");
            Console.WriteLine("4) Display the top student.");
            Console.WriteLine("5) Add a student.");
            Console.WriteLine("6) Change student grade.");
            Console.WriteLine("7) Exit.");
        }

        /* Function that will take input from the user based on the Menu options. */
        static int getUserOption()
        {
            Console.Write("Please choose from one of the menu options (1-7): ");
            /* Catch user entries that may be strings, and handle input out of range. */
            try
            {
                int output = Convert.ToInt32(Console.ReadLine());
                if (output < 1 || output > 7)
                {
                    displayMenu();
                    return getUserOption();
                }
                return output;
            } catch (Exception e)
            {
                displayMenu();
                return getUserOption();
            }
        }
        static void Main(string[] args)
        {

            while (true)
            {
                displayMenu();
                int menuSelection = getUserOption();
                Console.WriteLine("\n"+ menuSelection);
                Console.ReadKey();
            }
        }
    }
}
