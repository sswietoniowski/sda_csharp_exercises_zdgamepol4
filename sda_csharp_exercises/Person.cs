using System;

namespace sda_csharp_exercises
{
    class Person
    {
        private const int PROPER_AGE = 18;

        // fields
        private string firstName;
        //public string LastName;

        // properties
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(nameof(FirstName));
                }

                firstName = value;

                //if (!string.IsNullOrWhiteSpace(value))
                //{
                //    firstName = value;
                //}
            }
        }

        public string LastName { get; init; }

        public int YearOfBirth { get; init; }

        public void WhoAmI()
        {
            Console.WriteLine($"My Name is {LastName}. {FirstName} {LastName}");
        }

        //public bool IsAdult()
        //{
        //    int currentYear = DateTime.Now.Year;

        //    if (currentYear - YearOfBirth >= PROPER_AGE)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool IsAdult => (DateTime.Now.Year) - YearOfBirth >= PROPER_AGE;

        //public Person()
        //{
        //    Console.WriteLine($"{nameof(Person)} created without parameters");
        //}

        public Person(string firstName = "<NIEZNANE>", string lastName = "<NIEZNANE>", int yearOfBirth = 0)
        {
            this.firstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;

            Console.WriteLine($"{nameof(Person)} created with parameters");
        }
    }
}
