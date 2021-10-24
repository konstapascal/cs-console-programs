using System;
using System.Collections.Generic;
using System.Text;

namespace cs_console_programs
{
    public static class Games
    {
        public static void SimpleCalculatorGame()
        {
            Console.WriteLine("Enter the first number: ");
            string input1 = Console.ReadLine();
            int value1;

            while (!int.TryParse(input1, out value1))
            {
                Console.WriteLine("\nERR: Input is not a valid number. Try again!");
                input1 = Console.ReadLine();
            }

            string[] operands = { "+", "-", "*", "/" };

            Console.WriteLine("\nEnter operand:");
            string operand = Console.ReadLine();

            while(!Array.Exists(operands, val => val == operand))
            {
                Console.WriteLine("\nERR: Input is not a valid operand. Try again!");
                operand = Console.ReadLine();
            }

            Console.WriteLine("\nEnter the second number: ");
            string input2 = Console.ReadLine();
            int value2;

            while (!int.TryParse(input2, out value2))
            {
                Console.WriteLine("\nERR: Input is not a valid number. Try again!");
                input2 = Console.ReadLine();
            }

            Console.WriteLine("\nNumber 1 was " + value1);
            Console.WriteLine("Operand was " + operand);
            Console.WriteLine("Number 2 was " + value2);

            switch (operand)
            {
                case "+":
                    Console.WriteLine("\nResult is: " + Helpers.Add(value1, value2));
                    break;
                case "-":
                    Console.WriteLine("\nResult is: " + Helpers.Subtract(value1, value2));
                    break;
                case "*":
                    Console.WriteLine("\nResult is: " + Helpers.Multiply(value1, value2));
                    break;
                case "/":
                    Console.WriteLine("\nResult is: " + Helpers.Divide(value1, value2));
                    break;
                default:
                    Console.WriteLine("\nERR: Provided operand is not valid.");
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
                    $"You have won with {tries} tries left.");
            }
        }
    }
}
