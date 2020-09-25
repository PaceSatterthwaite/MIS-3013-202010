using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string userPrompt = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, " +
                "and the universe trying to build bigger and better idiots. So far, the universe is winning.";


            Console.WriteLine(userPrompt);
            Console.WriteLine();
            
            Console.WriteLine("What word do you want to look for in the above sentence?");
            string userFirstInput;
            userFirstInput = Console.ReadLine();
            Console.WriteLine();

            bool promptCheck = userPrompt.Contains(userFirstInput);

            if (promptCheck == false)
            {
                Console.WriteLine("Sorry, I could not find your word " + userFirstInput);

                for (int i = userFirstInput.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(userFirstInput[i]);
                }
                Console.ReadKey();
            }
            else if (promptCheck = true)
            {
                Console.WriteLine("What word do you want to change it to?");
                string userSecondInput;
                userSecondInput = Console.ReadLine();
                Console.WriteLine();

                var replacement = userPrompt.Replace(userFirstInput, userSecondInput);
                Console.WriteLine(replacement);

                userPrompt = userPrompt.ToUpper();
                Console.ReadKey();
            }

        }
    }
}
