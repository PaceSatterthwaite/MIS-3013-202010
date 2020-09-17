using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string min, max;
            int minInt, maxInt;
            string guessedNum;
            int guessedNumInt;

            Console.WriteLine("Welcome to the game 'Guess the Number'");
            Console.WriteLine("To start the game, pick the range of numbers");
            Console.WriteLine();

            Console.WriteLine("Enter the minimum number");
            min = Console.ReadLine();
            minInt = Convert.ToInt32(min);

            Console.WriteLine("Enter the maximum number");
            max = Console.ReadLine();
            maxInt = Convert.ToInt32(max);

            int number = rnd.Next(minInt, maxInt + 1);

            do
            {
                Console.WriteLine("Guess the number");
                guessedNum = Console.ReadLine();
                guessedNumInt = Convert.ToInt32(guessedNum);
     
            }
            while (guessedNumInt != number);

            Console.WriteLine("Congrats! You guessed the right number!");

            Console.ReadKey();
        }
    }
}
