using System;
using System.Collections.Generic;

namespace Project3
{
    class Program
    {

        /* Function that is called that display different use options. */
        static void displayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("MAIN MENU\n");
            Console.WriteLine("1) Reports");
            Console.WriteLine("2) Student Management");
            Console.WriteLine("3) Grade Management");
            Console.WriteLine("4) Exit");
            
        }

        /* Function that will display the different options for reporting students' grades. */
        static void displayReportMenu()
        {
            Console.Clear();
            Console.WriteLine("REPORT MENU\n");
            Console.WriteLine("1) Show all grades for a single student");
            Console.WriteLine("2) Display the name and grade AVG of the top student");
            Console.WriteLine("3) Return to Main Menu");
        }

        /* Function that will display the different options for the student management menu. */
        static void displayStuMgmtMenu()
        {
            Console.Clear();
            Console.WriteLine("STUDENT MANAGEMENT MENU\n");
            Console.WriteLine("1) Change student's name");
            Console.WriteLine("2) Add a student (no grades)");
            Console.WriteLine("3) Delete a student");
            Console.WriteLine("4) Return to Main Menu");
        }

        /* Function that will display the different options for the grade management menu. */
        static void displayGradeMgmtMenu()
        {
            Console.Clear();
            Console.WriteLine("GRADE MANAGEMENT MENU\n");
            Console.WriteLine("1) Change student's grade");
            Console.WriteLine("2) Add a new grade");
            Console.WriteLine("3) Delete a student's grade");
            Console.WriteLine("4) Return to Main Menu");
        }

        /* Function that will take input from the user based on the Menu options. Will take a parameter mode to determine different bounds
            for the different display menus. */
        static int getUserOption(int mode)
        {
            /* Catch user entries that may be strings, and handle input out of range. */

            if (mode == 1)      // main menu
            {
                try
                {
                    Console.Write("\nPlease choose from one of the menu options (1-4): ");
                    int output = Convert.ToInt32(Console.ReadLine());
                    if (output < 1 || output > 4)
                    {
                        return getUserOption(mode);
                    }
                    return output;
                }
                catch (Exception e)
                {
                    return getUserOption(mode);
                }
            }
            else if (mode == 2)     // report menu
            {
                try
                {
                    Console.Write("\nPlease choose from one of the menu options (1-3): ");
                    int output = Convert.ToInt32(Console.ReadLine());
                    if (output < 1 || output > 3)
                    {
                        return getUserOption(mode);
                    }
                    return output;
                }
                catch (Exception e)
                {
                    return getUserOption(mode);
                }
            }
            else if (mode == 3)     // stu. mgmt menu
            {     
                try
                {
                    Console.Write("\nPlease choose from one of the menu options (1-4): ");
                    int output = Convert.ToInt32(Console.ReadLine());
                    if (output < 1 || output > 4)
                    {
                        return getUserOption(mode);
                    }
                    return output;
                }
                catch (Exception e)
                {
                    return getUserOption(mode);
                }
            }
            else                // Grade Management
            {
                try
                {
                    Console.Write("\nPlease choose from one of the menu options (1-4): ");
                    int output = Convert.ToInt32(Console.ReadLine());
                    if (output < 1 || output > 4)
                    {
                        return getUserOption(mode);
                    }
                    return output;
                }
                catch (Exception e)
                {
                    return getUserOption(mode);
                }
            }
        }

        /* function that searches for a given student in the dictionary. */
        static bool searchFor(Dictionary<string, List<int>> students, string stuName)
        {
            bool found = false;
            foreach (KeyValuePair<string, List<int>> stuReport in students)
            {
                if (stuReport.Key.ToLower().Equals(stuName.ToLower()))
                {
                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine("\n{0} not found in the database", stuName);
            }
            return found;
        }

        /* Function that will take a student's name and newGrade, and will add that grade to their list of currently tracked grades. */
        static void addNewGrade(Dictionary<string, List<int>> students, string stuName, int newGrade)
        {
            if (searchFor(students, stuName))
            {
                students[stuName].Add(newGrade);
                displayStudent(students, stuName);
            }
            else 
            {
                Console.WriteLine("\n{0} is not in the database.\nNo changes were made.");
            }
        }

        /* Function that will take a students name, and the grade number that needs to be deleted. */
        static void deleteStudentGrade(Dictionary<string, List<int>> students, string stuName, int gradeNum)
        {
            // Student will always exist if this function is invoked (search done elsewhere).
            students[stuName].RemoveAt(gradeNum - 1);
            Console.WriteLine("\nGrade {0} was removed from {1}'s current grades.\n", gradeNum, stuName);
            displayStudent(students, stuName);

        }

        /* Function that will take a student's name, and the grade number that needs to be changed. */
        static void changeStudentGrade(Dictionary<string, List<int>> students, string stuName, int gradeNum)
        {
            if (gradeNum > students[stuName].Count & gradeNum != 1)
            {
                Console.WriteLine("There is not a grade {0} currently stored.", gradeNum);
                return;
            }
            // Student will always exist if this function is invoked (search done elsewhere).
            Console.Write("\nEnter the new grade to be saved : ");
            int newGrade = Convert.ToInt32(Console.ReadLine());
            if (students[stuName].Count != 0)
            {
                students[stuName].RemoveAt(gradeNum - 1);
                students[stuName].Insert(gradeNum - 1, newGrade);
                Console.WriteLine("\nGrade {0} was changed in {1}'s current grades.\n", gradeNum, stuName);
            }
            else
            {
                students[stuName].Insert(gradeNum - 1, newGrade);
                Console.WriteLine("\nGrade {0} was added in {1}'s current grades.\n", gradeNum, stuName);
            }
            displayStudent(students, stuName);

        }

        /* Function that will search the dictionary for the given name, if found it will ask for the new name that user would like the 
         *  student's name to be saved as. */
        static void changeStudentName(Dictionary<string, List<int>> students, string stuName)
        {
            if (searchFor(students, stuName))
            {
                Console.Write("\n{0} was found.\n\nWhat is their corrected name? : ", stuName);
                string newName = Console.ReadLine();
                // copy stuName's grades to newName's entry, then delete the stuName(oldName) entry from the database.
                students.Add(newName, students[stuName]);
                students.Remove(stuName);
                Console.WriteLine("\n{0} ==> {1} \n\t\tsuccessful.", stuName, newName);
            }
            else
            {
                Console.WriteLine("\nNo changes were made.");
            }
        }
            /* Function that will add a single student to the passed in dictionary with name incremented, and 3 random test grades. */
            static void addStudent(Dictionary<string, List<int>> students)
        {
            Random rand = new Random();

            Console.Write("What is the new students full name? : ");
            string stuName = Console.ReadLine();
            List<int> stuGrades = new List<int>();

            students.Add(stuName, stuGrades);
            Console.WriteLine("\n{0} was successfully added to the database", stuName);
        }

        /* Function that will delete a given student from the dictionary of students, if that student is in the dictionary. */
        static void deleteStudent(string stuName,Dictionary<string, List<int>> students)
        {
            if (searchFor(students, stuName))
            {
                students.Remove(stuName);
                Console.WriteLine("\n{0} was found and deleted from the Database.", stuName);
            }
            else
            {
                Console.WriteLine("\n{0} was not found in the Database.", stuName);
            }
        }

        /* Function that is used to display a specific of a given dictionary. The name of a student will be pass in. */
        static void displayStudent(Dictionary<string, List<int>> students, string stuName)
        {
            if (searchFor(students, stuName))
            {
                if (students[stuName].Count != 0)
                {
                    Console.WriteLine("Student: {0}\n", stuName);
                    int examNum = 1;
                    foreach (int grade in students[stuName])
                    {
                        Console.Write("\tGrade {0} : {1}%", examNum++, grade);
                    }
                    Console.WriteLine();
                } 
                else
                {
                    Console.WriteLine("Student: {0} \tCurrently has no grades.", stuName);
                }
            }
        }

        /* Function that is used to display the student with the highest test average. */
        static void findTopStudent(Dictionary<string, List<int>> students)
        {
            KeyValuePair<string, List<int>> topStu = new KeyValuePair<string, List<int>>("", new List<int> { 0, 0, 0});
            double topAVG = 0.0;
            foreach (KeyValuePair<string, List<int>> stuReport in students)
            {
                if (stuReport.Value.Count != 0)
                {
                    double totalPts = 0.0;
                    double stuAVG = 0.0;
                    foreach (int val in stuReport.Value)
                    {
                        totalPts += val;
                    }
                    stuAVG = Math.Round((totalPts / stuReport.Value.Count), 2);
                    if (stuAVG > topAVG)
                    {
                        topAVG = stuAVG;
                        topStu = stuReport;
                    }
                }
            }
            Console.WriteLine("\n{0} is the top student with an average score of {1}%\n", topStu.Key, topAVG);
        }
        static void Main(string[] args)
        {
            bool exit = false;
            Dictionary<string, List<int>> students = new Dictionary<string, List<int>>()
            {
                {"Alfred S. McKenzie",new List<int> {48, 96, 64}},
                {"Alison W. MacDonald",new List<int> {54, 99, 72}},
                {"Allan Y. Nguyen",new List<int> {42, 42, 41}},
                {"Audrey M. Kern",new List<int> {49, 67, 93}},
                {"Barry V. Gordon",new List<int> {66, 57, 52}},
                {"Beth G. Swanson",new List<int> {67, 55, 70}},
                {"Billy P. Carroll",new List<int> {70, 58, 80}},
                {"Calvin A. Diaz",new List<int> {86, 42, 50}},
                {"Charlotte G. Hamrick",new List<int> {43, 74, 40}},
                {"Chris Anderson",new List<int> {72, 67, 76}},
                {"Claire Q. Gray",new List<int> {63, 90, 47}},
                {"Clara H. Best",new List<int> {59, 63, 69}},
                {"Clifford Garrett",new List<int> {87, 89, 72}},
                {"Dean Leach",new List<int> {95, 40, 100}},
                {"Edgar P. Stuart",new List<int> {96, 49, 91}},
                {"Edna H. Hoyle",new List<int> {66, 70, 88}},
                {"Eileen Olson",new List<int> {100, 85, 51}},
                {"Franklin M. Coley",new List<int> {59, 63, 97}},
                {"Frederick J. McCall",new List<int> {97, 52, 57}},
                {"Glen R. Kramer",new List<int> {70, 48, 52}},
                {"Gordon D. Berman",new List<int> {88, 74, 46}},
                {"Jean M. Griffin",new List<int> {48, 86, 99}},
                {"Jeff T. Kaplan",new List<int> {54, 91, 72}},
                {"Joanna L. Middleton",new List<int> {43, 88, 73}},
                {"Joanne L. Bowling",new List<int> {78, 79, 79}},
                {"Julian E. Hendrix",new List<int> {99, 51, 91}},
                {"Keith X. Schwartz",new List<int> {97, 86, 97}},
                {"Ken T. Kennedy",new List<int> {80, 66, 40}},
                {"Kim T. Matthews",new List<int> {75, 95, 55}},
                {"Kristen O. Fisher",new List<int> {44, 72, 57}},
                {"Louise F. Coble",new List<int> {67, 63, 98}},
                {"Luis A. Burnett",new List<int> {85, 74, 52}},
                {"Luis N. Turner",new List<int> {86, 53, 86}},
                {"Margaret M. Burgess",new List<int> {76, 93, 63}},
                {"Martin Y. Hester",new List<int> {61, 74, 51}},
                {"Mary G. Byrd",new List<int> {95, 40, 95}},
                {"Nina Y. Savage",new List<int> {73, 41, 84}},
                {"Pauline N. Coley",new List<int> {73, 51, 87}},
                {"Penny Lamb",new List<int> {49, 94, 61}},
                {"Peter L. Guthrie",new List<int> {75, 70, 44}},
                {"Rhonda Chan",new List<int> {94, 52, 93}},
                {"Richard E. Hull",new List<int> {76, 99, 59}},
                {"Robyn K. Shapiro",new List<int> {45, 82, 68}},
                {"Samantha I. Hardin",new List<int> {89, 42, 95}},
                {"Sara Lucas",new List<int> {80, 60, 85}},
                {"Stephen Finch",new List<int> {84, 95, 70}},
                {"Tammy L. Lang",new List<int> {62, 73, 56}},
                {"Vincent Y. Fischer",new List<int> {79, 88, 92}},
                {"William S. McCormick",new List<int> {99, 68, 65}}
            };

            while (!exit)
            {
                displayMainMenu();
                int option = getUserOption(1);
                bool goToMain = false;
                switch (option)
                {
                    case 1:
                        while (!goToMain)
                        {
                            displayReportMenu();
                            int rOption = getUserOption(2);
                            if (rOption == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("REPORT - SINGLE STUDENT\n");
                                Console.Write("Enter the student's full name, or press ENTER to exit : ");
                                string stuName = Console.ReadLine();
                                if (stuName != "")
                                {
                                    Console.WriteLine();
                                    displayStudent(students, stuName);
                                }

                                Console.WriteLine("\n\nPress any key to return. . .");
                                Console.ReadKey();
                            }
                            else if (rOption == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("REPORT - TOP STUDENT\n");
                                findTopStudent(students);

                                Console.WriteLine("\n\nPress any key to return. . .");
                                Console.ReadKey();
                            }
                            else
                            {
                                goToMain = true;
                            } 
                        }
                        break;
                    case 2:
                        while (!goToMain)
                        {
                            displayStuMgmtMenu();
                            int sOption = getUserOption(3);
                            if (sOption == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("STUDENT MGMT - CHANGE STUDENT NAME\n");
                                Console.Write("Enter the student's full name, as it is in the database, that needs changing : ");
                                string stuName = Console.ReadLine();
                                changeStudentName(students, stuName);

                                Console.WriteLine("\n\nPress any key to return. . .");
                                Console.ReadKey();
                            }
                            else if (sOption == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("STUDENT MGMT - ADD NEW STUDENT\n");
                                addStudent(students);

                                Console.WriteLine("\n\nPress any key to return. . .");
                                Console.ReadKey();
                            }
                            else if (sOption == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("STUDENT MGMT - DELETE STUDENT\n");
                                Console.Write("Enter the student's full name, if found they will be deleted from the Database : ");
                                string stuName = Console.ReadLine();
                                deleteStudent(stuName, students);

                                Console.WriteLine("\n\nPress any key to return. . .");
                                Console.ReadKey();
                            }
                            else
                            {
                                goToMain = true;
                            } 
                        }
                        break;
                    case 3:
                        while (!goToMain)
                        {
                            displayGradeMgmtMenu();
                            int gOption = getUserOption(4);
                            if (gOption == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("GRADE MGMT - CHANGE A GRADE\n");
                                Console.Write("Enter the student's full name : ");
                                string stuName = Console.ReadLine();
                                if (searchFor(students, stuName))
                                {
                                    Console.WriteLine();
                                    displayStudent(students, stuName);
                                    Console.Write("\nEnter the grade # you would like to change(not the actual grade)\nIf the student has no grades, enter 1 : ");
                                    int gradeNum = Convert.ToInt32(Console.ReadLine());
                                    changeStudentGrade(students, stuName, gradeNum);

                                    Console.WriteLine("\n\nPress any key to return. . .");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("\n{0} was not found in the database.");
                                    continue;
                                }
                            }
                            else if (gOption == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("GRADE MGMT - ADD NEW GRADE\n");
                                Console.Write("Enter the student's full name : ");
                                string stuName = Console.ReadLine();
                                Console.Write("\nEnter the new grade (rounded) : ");
                                int newGrade = Convert.ToInt32(Console.ReadLine());
                                addNewGrade(students, stuName, newGrade);
                                Console.WriteLine();

                                Console.WriteLine("\n\nPress any key to return. . .");
                                Console.ReadKey();
                            }
                            else if (gOption == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("GRADE MGMT - DELETE A GRADE\n");
                                Console.Write("Enter the student's full name : ");
                                string stuName = Console.ReadLine();
                                if (searchFor(students, stuName))
                                {
                                    Console.WriteLine();
                                    displayStudent(students, stuName);
                                    Console.Write("\nEnter the grade # you would like to delete (not the actual grade) : ");
                                    int num = Convert.ToInt32(Console.ReadLine());
                                    deleteStudentGrade(students, stuName, num);

                                    Console.WriteLine("\n\nPress any key to return. . .");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("\n{0} was not found in the database.");
                                    continue;
                                }
                            }
                            else
                            {
                                goToMain = true;
                            } 
                        }
                        break;
                    case 4:
                        exit = true;
                        break;
                }
            }
        }
    }
}
