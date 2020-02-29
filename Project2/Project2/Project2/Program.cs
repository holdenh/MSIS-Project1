using System;
using System.Collections.Generic;

/*
 *      Holden Halferty
 *      
 *      Project 2. 
 */

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /**/
            List<int> deck = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 
                                                24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 
                                                47, 48, 49, 50, 51 };
            List<string> suits = new List<string>() { "Spades", "Hearts", "Diamods", "Clubs" };
            List<string> ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string cardSuit;
            string cardValue;

            foreach (int card in deck)
            {
                cardSuit = suits[(card / 13)];
                cardValue = ranks[(card % 13)];

                Console.WriteLine("Card #{0} : is the {1} of {2}.", card, cardValue, cardSuit);
            }

            Console.ReadKey();
        }
    }
}
