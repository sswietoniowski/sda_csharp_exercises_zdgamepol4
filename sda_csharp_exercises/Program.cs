using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.LastName = "Joanna";

            Person[] guests = new Person[]
            {
                new Person("Jan", "Kowalski", 1990),
                new Employee("Adam", "Nowak", 2000, 5_000.00M),
                new Person(),
                new Person()
                { // blok inicjalizcyjny konstruktora
                    FirstName = "Ewa",
                    LastName = "Niedźwiecka",
                    YearOfBirth = 2010
                }
            };

            Console.WriteLine("-----------------------------------------------------");

            foreach (var guest in guests)
            {
                guest.WhoAmI();

                //if (guest.GetType() == typeof(Employee))
                //{
                //    var employee = (Employee) guest;

                //    Console.WriteLine($"Salary: {employee.Salary}");
                //}

                //if (guest is Employee)
                //{
                //    var employee = (Employee)guest;
                //    Console.WriteLine($"Salary: {employee.Salary}");
                //}

                if (guest is Employee employee)
                {
                    Console.WriteLine($"Salary: {employee.Salary}");
                }

                //var e = (Employee) guest;
                //Console.WriteLine($"Salary: {e.Salary}");

                //var e = guest as Employee;
                //Console.WriteLine($"Salary: {e?.Salary}");
                //if (e is not null) // e != null
                //{
                //    Console.WriteLine($"Salary: {e.Salary}");
                //}
            }
        }
    }
}
