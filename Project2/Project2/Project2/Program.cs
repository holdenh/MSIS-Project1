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

            /* Variables */
            Random rand = new Random();
            List<int> deck = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 
                                                24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 
                                                47, 48, 49, 50, 51 };
            List<string> suits = new List<string>() { "Spades", "Hearts", "Diamods", "Clubs" };
            List<string> ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            List<string> pickedSuits = new List<string>();
            List<int> pickedCards = new List<int>();
            string cardSuit;
            string cardValue;
            int card;
            int randIndex;
            int remainingSuits = 4;
            int drawCount = 0;

            /* loop while we have not selected atleast one card from each of the four suits. */
            Console.WriteLine("Cards drawn :");
            while (remainingSuits != 0)
            {
                randIndex = rand.Next(0, deck.Count);
                card = deck[randIndex];
                cardSuit = suits[(card / 13)];
                cardValue = ranks[(card % 13)];

                Console.WriteLine("\tCard #{0}   : is the {1} of {2}.", card, cardValue, cardSuit);

                /* check if the suit has already had a card selected. */
                if (!pickedSuits.Contains(cardSuit))
                {
                    /* For a new suit, add to the list and decrement the counter. */
                    pickedSuits.Add(cardSuit);
                    pickedCards.Add(card);
                    remainingSuits--;
                }
                drawCount++;
            }
            Console.WriteLine("\nCards that make Suit Collection :");
            foreach (int pCard in pickedCards)
            {
                cardSuit = suits[(pCard / 13)];
                cardValue = ranks[(pCard % 13)];
                Console.WriteLine("\tCard #{0}  : is the {1} of {2}.", pCard, cardValue, cardSuit);
            }
            Console.WriteLine("\nNumber of draws: {0} ", drawCount);
            Console.ReadKey();
        }
    }
}
