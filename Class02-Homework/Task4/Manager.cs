using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(string name, int age, double baseSalary, double bonus, string department) : base(name, age,  baseSalary, bonus )
        {
            Department = department;
        }

        public override double CalculateSalary()
        {
            return BaseSalary + Bonus;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager: {Name}, Age: {Age}, Salary: {CalculateSalary()}, Department: {Department}");
        }
    }
}
