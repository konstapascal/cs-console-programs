using System;

namespace csharp_console_calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose a game:\n" +
                "\n1 - Calculator" +
                "\n2 - Number Guess\n");

            int game = Convert.ToInt32(Console.ReadLine());

            if (game == 1)
            {
                Console.WriteLine("\nYou have chosen to try the Calculator!\n");
                Games.CalculatorGame();
            } else if (game == 2)
            {
                Console.WriteLine("\nYou have chosen to try the Number Guesser!\n");
                Games.NumberGuessGame();
            } else
            {
                Console.WriteLine($"\nNo game with the id of {game}!");
            }
        }
    }

    public static class Games
    {
        public static void CalculatorGame()
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter operand (+ or -):");
            string operand = Console.ReadLine();

            Console.WriteLine("\nEnter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNumber 1 was " + num1);
            Console.WriteLine("Number 2 was " + num2);
            Console.WriteLine("Operand was " + operand);

            switch (operand)
            {
                case "+":
                    Console.WriteLine("\nSum is: " + HelperMethods.Add(num1, num2));
                    break;
                case "-":
                    Console.WriteLine("\nDifference is: " + HelperMethods.Subtract(num1, num2));
                    break;
                default:
                    Console.WriteLine("\nProvided operand is not valid.");
                    break;
            }
        }

        public static void NumberGuessGame()
        {
            Console.WriteLine("Try to guess the random number between 0 and 100. You have 10 tries!\n");

            int tries = 10;
            int answer = new Random().Next(100);

            GuessAttempt(answer, tries);

            static void GuessAttempt(int answer, int tries)
            {
                if (tries == 0) Console.WriteLine("Out of tries, you lost..");

                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > answer) 
                { 
                    tries--;
                    Console.WriteLine($"Too high!\nTries left: {tries}\n");
                    GuessAttempt(answer, tries);
                }

                if (guess < answer)
                {
                    tries--;
                    Console.WriteLine($"Too low!\nTries left: {tries}\n");
                    GuessAttempt(answer, tries);
                }

                if (guess == answer) Console.WriteLine($"Congratulations, the number was {answer}!\n" +
                    $"You have won with {tries} tries left.\n");
            }            
        }
    }

    public static class HelperMethods
    {
        public static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        public static int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
    }

}
