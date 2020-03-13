using System;
using System.Collections.Generic;

namespace InClassExercise1_Mod7
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;
            Dictionary<string, List<decimal>> receipt = new Dictionary<string, List<decimal>>(); // product, {quantity, unitPrice}
            int userSelection;
            string product = "";
            int amount = 0;
            decimal itemPrice = 0.0M;
            decimal totalPayment = 0.0M;
            decimal currBalance = 0.0M;
            decimal refund = 0.0M;
            while (!exit)
            {
               /* reset all variables. */
                product = "";
                amount = 0;
                itemPrice = 0.0M;
                totalPayment = 0.0M;
                currBalance = 0.0M;
                refund = 0.0M;

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

                        Console.Write("How many of the product would you like? : ");
                        amount = Convert.ToInt32(Console.ReadLine());
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
                            itemPrice = 1.00M;
                            product = "soda";
                            break;
                        case 2:
                            itemPrice = 2.00M;
                            product = "cookies";
                            break;
                        case 3:
                            itemPrice = 1.50M;
                            product = "chips";
                            break;
                        default:
                            Console.Clear();
                            continue;
                    }
                    
                    /* take user payment. */
                    currBalance = itemPrice * amount;

                    /* Add the product to the dictionary. use produce amount. */
                    if (!receipt.ContainsKey(product))
                    {
                        List<decimal> productDetails = new List<decimal>() { amount, itemPrice};
                        receipt[product] = productDetails;

                    }
                    else
                    {
                        receipt[product][0] += amount;
                    }
                    while (currBalance > 0)
                    {
                        Console.WriteLine("\nYou owe ${0} for your {1}.", currBalance, product);
                        decimal payment = 0;
                        Console.Write("Please insert a coin (5, 10, 25) : ");
                        try
                        {
                            payment = Convert.ToInt32(Console.ReadLine());
                            if (payment != 5 && payment != 10 && payment != 25)
                            {
                                Console.WriteLine("Not a valid input. Please try again.");
                                continue;
                            }
                            payment = payment / 100;
                            /* If payment is accepted, add to the total payment. */
                            totalPayment = totalPayment + payment;
                            Console.WriteLine("\n\t Total Payment: ${0}", totalPayment);
                            currBalance = currBalance - payment;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Not a valid input. Please try again.");
                            continue;
                        }
                    }

                    /* Give user a refund if needed (print refund statement.). 
                    if (currBalance < 0)
                    {
                        refund = currBalance * -1;
                        Console.WriteLine("\nYou overpayed for your {0}. Change back : {1} cents", product, refund);
                    }
                    */

                    /* Ask user if they want to purchase more products from machine. */
                    Console.WriteLine("Thank you for your purchase of {0}. Ejoy!\n\nMore products to buy?", product);
                    Console.Write("Enter y or n: ");
                    string moreProducts = Console.ReadLine();
                    if (moreProducts != "y")
                    {
                        exit = true;
                    }
                    Console.Clear();
                }
            }
            /* print the customers final receipt. */
            Console.WriteLine("Customer Receipt.");
            Console.WriteLine("ITEM\t\tQUANTITY\tUNITPRICE\tITEM TOTAL\n");
            decimal receiptTotal = 0;
            foreach (KeyValuePair<string, List<decimal>> item in receipt)
            {
                Console.WriteLine("{0}\t\t   {1}\t\t   {2}\t\t   ${3}", item.Key, item.Value[0], item.Value[1], ((item.Value[0] * item.Value[1])));
                receiptTotal += (item.Value[0] * item.Value[1]);
            }
            refund = totalPayment - receiptTotal;
            Console.WriteLine("\nGRAND TOTAL :\t${0}", receiptTotal);
            Console.WriteLine("TOTAL AMOUNT PAID : \t${0}", totalPayment);
            Console.WriteLine("\nCHANGE RETURNED : \t${0}",refund);

            Console.ReadKey();
        }
    }
}
