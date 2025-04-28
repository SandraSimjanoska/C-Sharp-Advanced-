//Task 4:
//Write a program to create an abstract class Employee with abstract methods CalculateSalary() and DisplayInfo().
//Create subclasses Manager and Programmer that extend the Employee class
//and implement the respective methods to calculate salary and display information for each role.
using Task4;

Console.WriteLine("Task 4");
// dali e pravilno vaka ili Programmer sandra = new programmer("Sandra", 27, 50000, 150, "C#"); ?
Employee sandra = new Programmer("Sandra", 27, 50000, 150, "C#");
sandra.DisplayInfo();
Console.WriteLine("----------------------------------------------------------");
Employee angel = new Manager("Angel", 27, 60000, 200, "IT");
angel.DisplayInfo();
