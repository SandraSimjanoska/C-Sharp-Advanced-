//Task 2
//Write a program to create an interface Shape with the GetArea() method. Create three classes
//Rectangle, Circle, and Triangle that implement the Shape interface. Implement the GetArea() method for each of the three classes.

using Task2;
using System;
using Task2.Classes;

Console.WriteLine("Task 2 Get Area");

Console.WriteLine("Enter the length of the rectangle:");
if (!double.TryParse(Console.ReadLine(), out double length))
{
    Console.WriteLine("Invalid length input");
    return;
}

Console.WriteLine("Enter the width of the rectangle:");
if (!double.TryParse(Console.ReadLine(), out double width))
{
    Console.WriteLine("Invalid width input");
    return;
}

Rectangle rectangle = new Rectangle(length, width);
Console.WriteLine($"Area of the rectangle: {rectangle.GetArea()}");

Console.WriteLine("----------------------------------------------------------");

Console.WriteLine("Enter the base of the triangle:");
if (!double.TryParse(Console.ReadLine(), out double baseLength))
{
    Console.WriteLine("Invalid base input");
    return;
}

Console.WriteLine("Enter the height of the triangle:");
if (!double.TryParse(Console.ReadLine(), out double height))
{
    Console.WriteLine("Invalid height input");
    return;
}

Triangle triangle = new Triangle(baseLength, height);
Console.WriteLine($"Area of the triangle: {triangle.GetArea()}");

Console.WriteLine("-----------------------------------------------------------");

Console.WriteLine("Enter the radius of the circle:");
if (!double.TryParse(Console.ReadLine(), out double radius))
{
    Console.WriteLine("Invalid radius input");
    return;
}

Circle circle = new Circle(radius);
Console.WriteLine($"Area of the circle: {circle.GetArea()}");