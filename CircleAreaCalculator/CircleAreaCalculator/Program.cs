using System;

namespace CircleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            // Part 1 (2-14-20)
            while (!exit)
            {
                // Part Two (2-14-20)
                Console.Write("Please enter the number of circles: ");
                int numCircles = Convert.ToInt32(Console.ReadLine());
                int currentCircle = 0;
                int maxTries = 3;
                int tryCounter = 0;
                while (currentCircle < numCircles)
                {
                    
                    Console.Write("Please enter the circle {0}'s radius: ", currentCircle+1);

                    // Step one
                    int radius = Convert.ToInt32(Console.ReadLine());
                    if (radius >= 0)
                    {
                        // Step two
                        Console.WriteLine("\nCalculating circle {0}", currentCircle + 1);
                        double area = radius * radius * Math.PI;

                        // Step three
                        Console.WriteLine(area + "\n");
                        currentCircle++;
                        tryCounter = 0;
                    }
                    else
                    {
                        tryCounter++;
                        if (maxTries - tryCounter == 0)
                        {
                            Console.WriteLine("You are out of tries for this circle. Moving to the next circle.\n");
                            currentCircle++;
                            tryCounter = 0;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, you have {0} tries left. Please enter a non-negative.\n", maxTries - tryCounter);
                        }
                    }
                }
                Console.WriteLine("\nMore calculations (Enter y or hit enter to exit.)?");
                string retry = Console.ReadLine();
                if (retry.ToLower() != "y")
                {
                    exit = true;
                }
                Console.Clear();
            }
        }
    }
}
