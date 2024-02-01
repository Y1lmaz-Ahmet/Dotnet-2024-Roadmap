using System;
using System.Collections.Generic;
public interface IDrawable
{
    void Draw();
}
public class Circle : IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}
public class Square : IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
}

class Program
{
    static void Main()
    {
        List<IDrawable> shapes = new List<IDrawable>
        {
            new Circle(),
            new Square(),
        };

        foreach (IDrawable shape in shapes)
        {
            shape.Draw();
        }
    }
}
