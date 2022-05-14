using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj podstawę: ");
            int basis = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj wykładnik: ");
            int exponent = Convert.ToInt32(Console.ReadLine());
            if (exponent < 0)
            {
                Console.WriteLine("Nie umiem policzyć wyniku dla ujemnej potęgi");
                return;
            }
            Console.WriteLine($"{basis} ^ {exponent} = {Power(basis, exponent)}");
        }

        private static int Power(int basis, int exponent)
        {
            int result = 1;

            for (int i = 1; i <= exponent; i++)
            {
                result *= basis;
            }

            return result;
        }
    }
}
