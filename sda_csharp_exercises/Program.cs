using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTriangle(5, '^');
        }

        private static void PrintTriangle(int lines, char symbol)
        {
            for (int i = 1; i <= lines; i++)
            {
                PrintLine(i, symbol);
            }

            for (int i = lines - 1; i >= 1; i--)
            {
                PrintLine(i, symbol);
            }
        }

        private static void PrintLine(int length, char symbol)
        {
            for (int i = 1; i <= length; i++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();
        }
    }
}
