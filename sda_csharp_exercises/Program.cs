using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.FirstName = "Jan"; // set
            //Console.WriteLine(person.FirstName); // get
            //person.FirstName = ""; // imię nie ulegnie zmianie
            //person.LastName = "Kowalski";
            //Console.WriteLine(person.LastName);

            Person person = new Person();
            person.FirstName = "Jan";
            person.LastName = "Kowalski";
            person.YearOfBirth = 1990;

            //Console.WriteLine($"{person.FirstName} {person.LastName} {person.YearOfBirth}");

            person.WhoAmI();

            //Console.WriteLine($"Is Adult: {person.IsAdult()}");
            Console.WriteLine($"Is Adult: {person.IsAdult}");
        }
    }
}
