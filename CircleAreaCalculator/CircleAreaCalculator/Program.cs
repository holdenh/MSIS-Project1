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
                int numCircles;
                int currentCircle = 0;
                int maxTries = 3;
                int tryCounter = 0;
                Console.Write("Please enter the number of circles: ");
                // Add try catch to handle bad input. (2-21-20).
                try 
                {
                    numCircles = Convert.ToInt32(Console.ReadLine());
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("This is not a valid input.");
                    continue;
                }
                while (currentCircle < numCircles)
                {
                    
                    Console.Write("Please enter the circle {0}'s radius: ", currentCircle+1);

                    // Step one
                    double radius;
                    // Add try catch block. (2-21-20)
                    try 
                    {
                        radius = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("This was not a valid input.");
                        // Ask if user wants to see the error exception.
                        //Console.Write("Print error exception?(y/n) : ");
                        //string printError = Console.ReadLine();
                        //if (printError.ToLower() == "y")
                        //{
                        //    Console.WriteLine("\n{0}\n", e.ToString());
                        //}
                        continue;
                    }
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
