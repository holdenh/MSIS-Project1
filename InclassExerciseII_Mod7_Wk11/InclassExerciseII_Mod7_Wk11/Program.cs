using System;
using System.Collections.Generic;
/**
 *      Holden Halferty
 *      
 *      Week 11 In Class Exercise
 * 
 */
namespace InclassExerciseII_Mod7_Wk11
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Part 1 
             *  make a dictionary that will holde student names and scores.
             *  Give each student three random scores from 60-100, and display.
             */
            Random rand = new Random();
            List<String> classList = new List<String> {"Corey", "Jim", "Rick", "Rachel" };
            Dictionary<String, Dictionary<int, List<int>>> students = new Dictionary<string, Dictionary<int, List<int>>>();
            
            // add students and grades.
            foreach (String student in classList)
            {
                List<int> grades = new List<int>();
                for (int i = 0; i < 3; i++)
                {
                    int grade = rand.Next(60, 101);
                    grades.Add(grade);
                }
                /* Part 2
                 *  calculate each students average to display.
                 */
                int total = 0;
                foreach (int g in grades)
                {
                    total += g;
                }
                int avg = total / grades.Count;
                Dictionary<int, List<int>> gradeReport = new Dictionary<int, List<int>>();
                gradeReport.Add(avg, grades);
                students.Add(student, gradeReport);
            }


            // Display
            Console.WriteLine("Week 11. Inclass Exercise II(Mod7).\n");
            foreach (KeyValuePair<String, Dictionary<int, List<int>>> stuReport in students)
            {
                Dictionary<int, List<int>> report = stuReport.Value;
                foreach (KeyValuePair<int, List<int>> g in report)
                {
                    Console.WriteLine("Student: {0}\n\tExam 1: {1}%\tExam 2: {2}%\tExam 3: {3}%\n\t{0}'s Exam Avg: {4}%", stuReport.Key, g.Value[0], g.Value[1], g.Value[2], g.Key);
                }

            }
            // Find student will the highest avg.
            int max = 0;
            foreach (KeyValuePair<String, Dictionary<int, List<int>>> stuReport in students)
            {
                Dictionary<int, List<int>> report = stuReport.Value;
                
                foreach (int key in report.Keys)
                {
                    if (key > max)
                    {
                        max = key;
                    }
                }
                
            }
            foreach (KeyValuePair<String, Dictionary<int, List<int>>> stuReport in students)
            {
                Dictionary<int, List<int>> report = stuReport.Value;
                foreach (KeyValuePair<int, List<int>> g in report)
                {
                    if (g.Key == max)
                    {
                        Console.WriteLine("\n\n{0} has the highest average of {1}%", stuReport.Key, g.Key);
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }
    }
}
