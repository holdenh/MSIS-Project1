using System;

namespace InClassExercise1_Mod5
    /* Feb. 24th, 2020
     *      Vending Machine mock up. 
     *      User will enter their selection, and the program will display the payment amount.
     *      User will then insert coins(5,10,25) to reduce the overall price, and the program will take payment until the product is paid for.
     *      Make sure to return change to the user.
    */
{
    class Program
    {
        static void Main(string[] args)
        {
            int userSelection;
            double itemPrice;

            Console.WriteLine("WELCOME TO THE VENDING MACHINE");
            while (true)
            {

                /* Take user input for the vending machine selection. */
                Console.Write("We can offer you (1)soda - $1, (2)cookies - $2, or (3)chips - $1.50.\nPlease select a product(Enter to exit): ");
                try
                {
                    userSelection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Not a valid selection. Please try again.");
                    continue;
                }

                /* Handle setting itemPrice given the user input.  */
                switch (userSelection)
                {
                    case 1:
                        itemPrice = 1.00;
                        break;
                    case 2:
                        itemPrice = 2.00;
                        break;
                    case 3:
                        itemPrice = 1.50;
                        break;

                }

            }
        }
    }
}
