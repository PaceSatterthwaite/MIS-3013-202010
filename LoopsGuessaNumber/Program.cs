using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsGuessaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pace Satterthwaite Homwork 1a

            string userQuantity;
            int userQuantityInt;
            string userPrice;
            double userPriceInt;
            const double taxrate = .085;
            
            Console.WriteLine("Guess a random number");
            Random rnd = new Random();
            int number = rnd.Next(1, 3);
            int heads = 1;
            int tails = 2;



            Console.WriteLine("Enter 1 for heads or 2 for tails");
            string userInput = Console.ReadLine();



            Console.WriteLine("What is the product name of the item you are purchasing?");
            string userItem = Console.ReadLine();

            Console.WriteLine("How many " + userItem + "'s do you want to buy?");
            userQuantity = Console.ReadLine();
            userQuantityInt = Convert.ToInt32(userQuantity);

            Console.WriteLine("What is the price for each " + userItem);
            userPrice = Console.ReadLine();
            userPriceInt = Convert.ToDouble(userPrice);

            double subtotal = userQuantityInt * userPriceInt;
            double totalTax = subtotal * taxrate;
            double totalBill = totalTax + subtotal;

            string formattedSubtotalAsString = subtotal.ToString("C2");
            string formattedTotalTaxAsString = totalTax.ToString("C2");
            string formattedTotalBillAsString = totalBill.ToString("C2");

            Console.WriteLine("     Your subtotal for your bill is " + formattedSubtotalAsString);
            Console.WriteLine("     Your sales tax for your bill is " + formattedTotalTaxAsString);
            Console.WriteLine("     Your total for your bill is " + formattedTotalBillAsString);

            Console.ReadLine();
        }
    }
}
