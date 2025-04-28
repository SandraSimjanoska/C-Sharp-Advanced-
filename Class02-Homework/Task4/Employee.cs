using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public double BaseSalary { get; set; }
        public double Bonus { get; set; }

        public Employee(string name, int age, double baseSalary, double bonus)
        {
            Name = name;
            Age = age;
            BaseSalary = baseSalary;
            Bonus = bonus;
        }
        public abstract double CalculateSalary();
        public abstract void DisplayInfo();
    }
}
