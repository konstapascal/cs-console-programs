using System;

namespace csharp_console_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Print("\nEnter operand (+ or -):");
            string operand = Console.ReadLine();

            Print("\nEnter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Print("\nNumber 1 was " + num1);
            Print("Number 2 was " + num2);
            Print("Operand was " + operand);

            switch (operand)
            {
                case "+":
                    Print("\nSum is: " + Add(num1, num2));
                    break;
                case "-":
                    Print("\nDifference is: " + Subtract(num1, num2));
                    break;
                default:
                    Print("Provided operand is not valid.");
                    break;
            }
        }

        static void Print(string str)
        {
            Console.WriteLine(str);
        }
        static int Add(int num1, int num2 )
        {
            int result = num1 + num2;
            return result;
        }
        static int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

    }
}
