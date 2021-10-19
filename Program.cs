using System;

namespace csharp_console_calculator
{
    class Program
    {
        static void Main(string[] args)
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
                    Console.WriteLine("\nSum is: " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                default:
                    Console.WriteLine("Provided operand is not valid.");
                    break;
            }
        }
    }
}
