using System;
using System.Text;

namespace sda_csharp_exercises
{
    class Program
    {
        private static readonly char[] leetLetters = { '4', '3', '1', '0', '$' };
        private static readonly char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };

        static void Main(string[] args)
        {
            string text = "Asia";
            Console.WriteLine($"Text: {text}");
            string leetSpeak = ToLeetSpeak(text);
            Console.WriteLine($"Leet Speak: {leetSpeak}");
            string decodedText = FromLeetSpeak(leetSpeak);
            Console.WriteLine($"Decoded Text: {decodedText}");
        }

        private static string ToLeetSpeak(string text)
        {
            char[] characters = text.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                char lowerCharacter = Char.ToLower(characters[i]);

                for (int j = 0; j < naturalLetters.Length; j++)
                {
                    if (lowerCharacter == naturalLetters[j])
                    {
                        characters[i] = leetLetters[j];
                    }
                }
            }

            return new String(characters);
        }

        private static string FromLeetSpeak(string leetSpeak)
        {
            char[] characters = leetSpeak.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                char lowerCharacter = Char.ToLower(characters[i]);

                for (int j = 0; j < leetLetters.Length; j++)
                {
                    if (lowerCharacter == leetLetters[j])
                    {
                        characters[i] = naturalLetters[j];
                    }
                }
            }

            return new String(characters);
        }
    }
}
