using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            string goodPesel = "55030101193";
            Console.WriteLine($"{goodPesel} is valid: {IsValidPesel(goodPesel)}");

            string badPesel = "55030101194";
            Console.WriteLine($"{badPesel} is valid: {IsValidPesel(badPesel)}");
        }

        private static bool IsValidPesel(string pesel)
        {
            const int PESEL_IMPORTANT_DIGITS = 10;
            const int PESEL_CHECKSUM_INDEX = 10;
            
            int[] weights = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1};

            int sum = 0;
            for (int i = 0; i < PESEL_IMPORTANT_DIGITS; i++)
            {
                sum += int.Parse($"{pesel[i]}") * weights[i];
            }

            int m = sum % 10;

            int checksum = 10 - m;
            checksum = (checksum == 10) ? 0 : checksum;

            int encodedChecksum = int.Parse($"{pesel[PESEL_CHECKSUM_INDEX]}");

            return checksum == encodedChecksum;
        }
    }
}
