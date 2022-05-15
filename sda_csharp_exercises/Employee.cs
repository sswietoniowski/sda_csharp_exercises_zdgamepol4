using System;

namespace sda_csharp_exercises
{
    class Employee : Person
    {
        public decimal Salary { get; set; }

        public Employee()
        {
            Console.WriteLine($"{nameof(Employee)} created without parameters");
        }

        public Employee(string firstName, string lastName, int yearOfBirth, decimal salary)
            : base(firstName, lastName, yearOfBirth)
        {
            Salary = salary;

            Console.WriteLine($"{nameof(Employee)} created with parameters");
        }

        public virtual decimal GetTotalSalary()
        {
            return Salary;
        }

        //public void WhoAmI()
        //{
        //    base.WhoAmI();
        //    Console.WriteLine($"My salary is {Salary}");
        //}

        public override void WhoAmI()
        {
            base.WhoAmI();
            Console.WriteLine($"My salary is {GetTotalSalary():F2}");
        }
    }
}
