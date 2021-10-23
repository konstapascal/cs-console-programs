using System;

namespace cs_console_programs
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PROGRAM_COUNT = 2;

            Console.WriteLine("Choose a program to start:\n" +
                "\n1 - Simple Calculator" +
                "\n2 - Number Guesser\n");

            int program = Convert.ToInt32(Console.ReadLine());

            while (program < 1 || program > PROGRAM_COUNT)
            {
                Console.WriteLine($"\nInvalid number, choose a program number between 1 and {PROGRAM_COUNT}.");
                program = Convert.ToInt32(Console.ReadLine());
            } 

            switch (program)
            {
                case 1:
                    Console.WriteLine("\nYou have chosen to try the Simple Calculator!");
                    Games.SimpleCalculatorGame();
                    return;
                case 2:
                    Console.WriteLine("\nYou have chosen to try the Number Guesser!");
                    Games.NumberGuesserGame();
                    return;
            }

        }
    }
}
