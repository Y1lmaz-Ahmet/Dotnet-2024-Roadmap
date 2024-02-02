using System;
using System.Collections.Generic;

// Abstract Class Shape
abstract class Shape
{
    // Abstract method CalculateArea that must be implemented by derived classes
    public abstract double CalculateArea();
}
// Circle class inheriting from shape : (child class)[Circle] : (base class)[Shape]
class Circle : Shape
{
    // Property of a cricle
    public double Radius { get; set; }
    // Constructor for a circle
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
// Rectangle class inheriting from shape : (child class)[Rectangle] : (base class)[Shape]
class Rectangle : Shape
{
    // Properties of a rectangle
    public double Width { get; set; }
    public double Height { get; set; }
    // Constructor for a rectangle
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public override double CalculateArea()
    {
        return Width * Height;
    }
}
class Program
{
    static void Main()
    {
        // Creating a list of shapes to loop over 😎
        List<Shape> shapes = new List<Shape>
        {
            new Circle(5), // 5 = radius
            new Rectangle(4,6), // (width, height)
            new Circle(3.5),
            new Rectangle(2.8,9)
        };
        // Calculate & print the are of shape
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"chosen shape: {shape.GetType().Name}\nAre of the shape: {shape.CalculateArea():F2}\n");
        }
        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}
