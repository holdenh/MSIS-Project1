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

            while (true)
            {
                int userSelection;
                string product = "";
                double itemPrice = 0;
                double totalPayment = 0;
                double currBalance = 0;

                bool takeProduct = true;
                Console.WriteLine("WELCOME TO THE VENDING MACHINE");
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
                            itemPrice = 1.00;
                            product = "soda";
                            break;
                        case 2:
                            itemPrice = 2.00;
                            product = "cookies";
                            break;
                        case 3:
                            itemPrice = 1.50;
                            product = "chips";
                            break;

                    }

                    /* take user payment. */
                    currBalance = itemPrice - totalPayment;
                    while (totalPayment < currBalance)
                    {
                        double payment = 0;
                        currBalance = itemPrice - totalPayment;
                        Console.WriteLine("You still owe {0} for your {1}.", currBalance, product);
                        Console.Write("Please insert a coin : ");
                        try
                        {
                            payment = Convert.ToInt32(Console.ReadLine());
                            if (payment != 5 && payment != 10 && payment != 25)
                            {
                                Console.WriteLine("Not a valid input. Please try again.");
                                continue;
                            }
                            /* If payment is accepted, add to the total payment. */
                            payment = payment / 100;
                            totalPayment = totalPayment + payment;
                            Console.WriteLine(totalPayment);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Not a valid input. Please try again.") ;
                            continue;
                        }
                    }
                } 
            }
        }
    }
}
