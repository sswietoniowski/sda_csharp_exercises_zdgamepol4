using System;

namespace sda_csharp_exercises
{
    class Program
    {
        const int NON_UNIQUE_NUMBER = -1;

        private static void PrintUniqueNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];

                if (IsUnique(number))
                {
                    int fromPosition = i + 1;
                    MarkDuplicates(numbers, number, fromPosition);
                }
            }

            PrintOnlyUniqueNumbers(numbers);
        }

        private static bool IsUnique(int number) => number != NON_UNIQUE_NUMBER;

        private static void MarkDuplicates(int[] numbers, int number, int fromPosition)
        {
            for (int j = fromPosition; j < numbers.Length; j++)
            {
                if (!IsUnique(numbers[j]))
                {
                    continue;
                }

                if (numbers[j] == number)
                {
                    numbers[j] = NON_UNIQUE_NUMBER;
                }
            }
        }

        private static void PrintOnlyUniqueNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (IsUnique(number))
                {
                    Console.Write($"{number} ");
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 1, 2, 5 };

            PrintUniqueNumbers(numbers);
        }
    }
}
