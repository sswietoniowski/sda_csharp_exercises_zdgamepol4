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
            int counter = 1;
            while (counter <= lines)
            {
                PrintLine(counter, symbol);
                counter++;
            }

            counter--;
            do
            {
                counter--;
                PrintLine(counter, symbol);
            } while (counter > 1);
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
