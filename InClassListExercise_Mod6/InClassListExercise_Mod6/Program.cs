using System;
using System.Collections.Generic;

namespace InClassListExercise_Mod6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myNums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Original List");
            for (int i = 0; i < myNums.Count; i++)
            {
                Console.WriteLine("Element #{0} : {1}", i, myNums[i] );
            }


            List<int> emptyList = new List<int>();
            List<int> revList = revRecur(myNums, emptyList);
           
            Console.WriteLine("\nReverseList");
            for (int i = 0; i < revList.Count; i++)
            {
                Console.Write(revList[i] + " ");
            }
            Console.ReadKey();
        }

        /* recursive function that takes an input list and returns a list that is reversed.  */
        public static List<int> revRecur (List<int> inList, List<int> outList)
        {
            /* Base Case */
            if (inList.Count == 0)
            {
                Console.WriteLine("Done reversing.");
            }
            /* Inductive Case */
            else
            { 
                outList.Add(inList[inList.Count-1]);
                inList.RemoveAt(inList.Count - 1);
                revRecur(inList, outList);
            }
            return outList;
        }
    }
}
