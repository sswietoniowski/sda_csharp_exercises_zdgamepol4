using System;
using System.Text.RegularExpressions;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string weakPassword = "dupa";
            string strongPassword = "bpG1410PK3:0$";

            Console.WriteLine(CheckPasswordComplexity(weakPassword));
            Console.WriteLine();
            Console.WriteLine(CheckPasswordComplexity(strongPassword));
            Console.WriteLine();
            Console.WriteLine(CheckPasswordComplexityWithRegex(weakPassword));
            Console.WriteLine(CheckPasswordComplexityWithRegex(strongPassword));

        }

        private static bool CheckPasswordComplexity(string password)
        {
            bool hasRequiredLength = HasRequiredLength(password);
            Console.WriteLine($"Has Required Length: {hasRequiredLength}");
            bool containsLowerAndUpperLetter = ContainsLowerAndUpperLetter(password);
            Console.WriteLine($"Contains Lower And Upper Letter: {containsLowerAndUpperLetter}");
            bool containsDigit = ContainsDigit(password);
            Console.WriteLine($"Contains Digit: {containsDigit}");
            bool containsSpecialCharacter = ContainsSpecialCharacter(password);
            Console.WriteLine($"Contains Special Character: {containsSpecialCharacter}");

            return hasRequiredLength
                   && containsLowerAndUpperLetter
                   && containsDigit
                   && containsSpecialCharacter;
        }

        private static bool ContainsLowerAndUpperLetter(string password)
        {
            bool containsLowerLetter = false;
            bool containsUpperLetter = false;

            foreach (var character in password)
            {
                if (Char.IsLower(character))
                {
                    containsLowerLetter = true;
                }
                else if (Char.IsUpper(character))
                {
                    containsUpperLetter = true;
                }
            }

            return containsLowerLetter && containsUpperLetter;
        }

        private static bool ContainsSpecialCharacter(string password)
        {
            const string SPECIAL_CHARACTERS = "&*$#";

            foreach (var character in password)
            {
                if (SPECIAL_CHARACTERS.Contains(character))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool ContainsDigit(string password)
        {
            foreach (var character in password)
            {
                if (Char.IsDigit(character))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool HasRequiredLength(string password)
        {
            const int MIN_PASSWORD_LENGTH = 6;

            return password.Length >= MIN_PASSWORD_LENGTH;
        }

        private static bool CheckPasswordComplexityWithRegex(string password)
        {
            const string PASSWORD_PATTERN = 
                @"(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[&*$#])(?=.{6,})";

            return Regex.IsMatch(password, PASSWORD_PATTERN);
        }
    }
}
