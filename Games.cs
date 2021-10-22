using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_console_calculator
{
    public static class Games
    {
        public static void SimpleCalculatorGame()
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
                    Console.WriteLine("\nSum is: " + Helpers.Add(num1, num2));
                    break;
                case "-":
                    Console.WriteLine("\nDifference is: " + Helpers.Subtract(num1, num2));
                    break;
                default:
                    Console.WriteLine("\nProvided operand is not valid.");
                    break;
            }
        }

        public static void NumberGuesserGame()
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

                if (guess == answer) Console.WriteLine($"\nCongratulations, the number was {answer}!\n" +
                    $"You have won with {tries} tries left.\n");
            }
        }
    }
}
