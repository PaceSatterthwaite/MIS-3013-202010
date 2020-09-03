using System;

namespace Participation1_SumOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double total;
            double totalWithExtras = 7.777;

            Console.WriteLine("Please enter your first number >>");
            double first = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your second number >>");
            double second = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your third number >>");
            double third = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your Sum of Numbers Equals");
            total = first + second + third;
            String formattedNumberAsAString = total.ToString("F3");
            Console.WriteLine(formattedNumberAsAString);

            Console.WriteLine("The second value if you multiply the sum of the 3 numbers by a constant value of 7.777 would be >>");
            total = total * totalWithExtras;
            Console.WriteLine(total);
        }
    }
}
