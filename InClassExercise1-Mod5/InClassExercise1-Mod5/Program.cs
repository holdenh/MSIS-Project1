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

            bool exit = false;
            while (!exit)
            {
                int userSelection;
                string product = "";
                double itemPrice = 0;
                double totalPayment = 0;
                double currBalance = 0;
                double refund = 0;

                bool takeProduct = true;
                Console.WriteLine("WELCOME TO THE VENDING MACHINE\n\n");
                while (takeProduct)
                {

                    /* Take user input for the vending machine selection. */
                    Console.Write("We can offer you (1)soda - $1, (2)cookies - $2, or (3)chips - $1.50.\nPlease select a product: ");
                    try
                    {
                        userSelection = Convert.ToInt32(Console.ReadLine());
                        takeProduct = false;
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
                            itemPrice = 100;
                            product = "soda";
                            break;
                        case 2:
                            itemPrice = 200;
                            product = "cookies";
                            break;
                        case 3:
                            itemPrice = 150;
                            product = "chips";
                            break;
                        default:
                            Console.Clear();
                            continue;
                    }

                    /* take user payment. */
                    currBalance = itemPrice;
                    while (currBalance > 0)
                    {
                        Console.WriteLine("\nYou owe {0} cents for your {1}.", currBalance, product);
                        int payment = 0;
                        Console.Write("Please insert a coin (5, 10, 25) : ");
                        try
                        {
                            payment = Convert.ToInt32(Console.ReadLine());
                            if (payment != 5 && payment != 10 && payment != 25)
                            {
                                Console.WriteLine("Not a valid input. Please try again.");
                                continue;
                            }
                            /* If payment is accepted, add to the total payment. */
                            totalPayment = totalPayment + payment;
                            Console.WriteLine("\n\t Total Payment: {0}", totalPayment);
                            currBalance = currBalance - payment;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Not a valid input. Please try again.");
                            continue;
                        }
                    }

                    /* Give user a refund if needed (print refund statement.). */
                    if (currBalance < 0)
                    {
                        refund = currBalance * -1;
                        Console.WriteLine("\nYou overpayed for your {0}. Change back : {1} cents", product, refund);
                    }
                    /* Ask user if they want to purchase more products from machine. */
                    Console.WriteLine("Thank you for your purchase of {0}. Ejoy!\n\nMore products to buy?",product);
                    Console.Write("Enter y or n: ");
                    string moreProducts = Console.ReadLine();
                    if (moreProducts != "y")
                    {
                        exit = true;
                    }
                    Console.Clear();
                }
            }
        }
    }
}
