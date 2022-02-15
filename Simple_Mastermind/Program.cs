using System;

namespace Simple_Mastermind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Application");
            Console.WriteLine("\nGenerating 4 digit number between 1 and 6, both digits included");
            Console.WriteLine("You have up to 10 tries to guess secret code.");
            Console.WriteLine("After your guess, you will get a 4-digit response based on your answer");
            Console.WriteLine(" '+' character means your guess was correct and is in that position.");
            Console.WriteLine(" '-' character means that digit is one of the 4 digitd, but not in correct position.");
            Console.WriteLine(" ' ' means that digit is not in the random 4 digits number at all.");
            Console.WriteLine("\nEnter your first guess now.");

            var game = new Mastermind_Game();

            do
            {
                Console.Write("\n> ");
                var guess = Console.ReadLine();

                Console.WriteLine(game.Guess(guess));

            } while (!game.IsFinished);
        }
    }
}
