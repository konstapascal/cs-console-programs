using System;

namespace csharp_console_calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose a program to start:\n" +
                "\n1 - Simple Calculator" +
                "\n2 - Number Guesser\n");

            int game = Convert.ToInt32(Console.ReadLine());

            if (game == 1)
            {
                Console.WriteLine("\nYou have chosen to try the Simple Calculator!\n");
                Games.SimpleCalculatorGame();
            } else if (game == 2)
            {
                Console.WriteLine("\nYou have chosen to try the Number Guesserer!\n");
                Games.NumberGuesserGame();
            } else
            {
                Console.WriteLine($"\nNo game with the id of {game}!");
            }
        }
    }
}
