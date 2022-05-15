using System;

namespace sda_csharp_exercises
{
    class Person
    {
        private const int PROPER_AGE = 18;

        // fields
        private string _firstName;
        //public string LastName;

        // properties
        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(nameof(FirstName));
                }

                _firstName = value;

                //if (!string.IsNullOrWhiteSpace(value))
                //{
                //    _firstName = value;
                //}
            }
        }

        public string LastName { get; set; }

        public int YearOfBirth { get; set; }

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
    }
}
