//Task 3:
//Write a program to create an abstract class Shape with
//abstract methods CalculateArea() and CalculatePerimeter().
//Create subclasses Circle and Triangle that extend the Shape class and
//implement the respective methods to calculate the area and perimeter of each shape.
using Task3;

Console.WriteLine("Task 3");

Console.WriteLine("Enter the radius to calculate the area and perimeter of a circle:");
if (!double.TryParse(Console.ReadLine(), out double radius))
{
    Console.WriteLine("Invalid radius input");
    return;
}
Circle circle = new Circle(radius);
Console.WriteLine($"Area of the circle: {circle.CalculateArea()}");
Console.WriteLine($"Perimeter of the circle: {circle.CalculatePerimeter()}");


Console.WriteLine("----------------------------------------------------------");

Console.WriteLine("Enter the base to calucalte the area of a triangle:");
if (!double.TryParse(Console.ReadLine(), out double baseLength))
{
    Console.WriteLine("Invalid base input");
    return;
}

Console.WriteLine("Enter the height to calucalte the area of a triangle:");
if (!double.TryParse(Console.ReadLine(), out double height))
{
    Console.WriteLine("Invalid height input");
    return;
}
Triangle triangle = new Triangle(baseLength, height);
Console.WriteLine($"Area of the triangle: {triangle.CalculateArea()}");

