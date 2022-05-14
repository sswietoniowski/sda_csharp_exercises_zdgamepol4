using System;

namespace sda_csharp_exercises
{
    class Program
    {
        private static void BubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int tmp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = tmp;
                    }
                }

                Console.WriteLine($"Przejście: {i + 1}");
                PrintNumbers(numbers);
            }
        }

        private static void PrintNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] numbers = { 3, 5, -1, 0, 20, 16, 1, 7 };

            Console.WriteLine("Tablica przed posortowaniem: ");
            PrintNumbers(numbers);
            Console.WriteLine("Sortowanie tablicy:");

            BubbleSort(numbers);

            //Array.Sort(numbers);

            Console.WriteLine("Tablica po posortowaniu: ");
            PrintNumbers(numbers);
        }
    }
}
