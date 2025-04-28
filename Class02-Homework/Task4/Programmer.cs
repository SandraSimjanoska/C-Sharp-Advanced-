
namespace Task4
{
    public class Programmer : Employee
    {
        public string ProgrammingLanguage { get; set; }
        public Programmer(string name, int age, double baseSalary, double bonus, string programmingLanguage) : base(name, age, baseSalary, bonus)
        {
            ProgrammingLanguage = programmingLanguage;
        }
        public override double CalculateSalary()
        {
            return BaseSalary + Bonus;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Programmer: {Name}, Age: {Age}, Salary: {CalculateSalary()}, Programming Language: {ProgrammingLanguage}");
        }
    }
}
