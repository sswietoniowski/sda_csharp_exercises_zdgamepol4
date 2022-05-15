using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee("Jan", "Kowalski", 2000, 5_000.00M);
            ////employee.WhoAmI();

            //Person person = employee;
            //person.WhoAmI();
            Employee[] employees = new Employee[]
            {
                new Employee("Jan", "Kowalski", 1990, 5_000.00M),
                new Manager("Adam", "Nowak", 2000, 5_000.00M),
            };

            foreach (var employee in employees)
            {
                employee.WhoAmI();
            }
        }

        static void PrintHello(Person[] guests)
        {
            foreach (var guest in guests)
            {
                if (guest.IsAdult)
                {
                    Console.WriteLine("Witaj w sklepie monopolowym");
                }
                else
                {
                    Console.WriteLine("Witaj w sklepie z zabawkami");
                }
            }
        }
    }
}
