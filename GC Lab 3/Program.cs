using System;

namespace GC_Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userContinue;

            Console.WriteLine("Hi there! What's your name?");
            string userName = Console.ReadLine();
            do
            {
                Console.WriteLine();
                Console.WriteLine($"{userName}, please enter a number between 1 and 100.");
                var userInput = int.TryParse(Console.ReadLine(), out int result);

                if (userInput && result <=100)
                {
                    if (result % 2 != 0 && result > 60 && result >=0)
                    {
                        Console.WriteLine($"You entered {result}, which is an odd number.");
                    }
                    else if (result % 2 != 0)
                    {
                        Console.WriteLine("Odd.");
                    }
                    else if (result % 2 == 0 && result < 25)
                    {
                        Console.WriteLine("Even and less than 25.");
                    }
                    else if (result % 2 == 0 && result > 25 && result <= 60)
                    {
                        Console.WriteLine("Even.");
                    }
                    else if (result % 2 == 0 && result > 60)
                    {
                        Console.WriteLine($"You entered {result}, which is an even number.");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Do you want to continue, {userName}? Y/N");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Hey {userName}, you entered an invalid input - Please enter a number between 0 and 100!");
                }

                userContinue = Console.ReadLine().ToLower();
                Console.WriteLine();

            } while (userContinue != "n");
            Console.WriteLine($"Seeya {userName}!");


        }
    }
}

