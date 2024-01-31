using System;

// Overriding method Line 7 Creating & 16 overriding;
public class Shape
{
    // Creating virtual method in parent class by defining 'virtual'
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}

public class Circle : Shape
{
    // Overriding the virtual method of the parent class by using 'override'
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

// Overriding properties Line 25 'virtual string Sound(25)' => 'override string Sound(29)'
public class Animal
{
    public virtual string Sound => "Generic animal sound.";
    public virtual int age => 0;
}
public class Dog : Animal
{
    public override string Sound => "Bark!";
    public override int age => 9;
}
// Virtual Indexer for setter & Getter
public class Library
{
    private string[] books = new string[5]; // 5 = length
    public virtual string this[int index]
    {
        get => books[index];
        set => books[index] = value;
    }
}
public class SpecialLibrary : Library
{
    public override string this[int index]
    {
        get => $"Special: {base[index]}";
        set => base[index] = value;
    }
}
class Program
{
    static void Main()
    {
        Shape shape = new Circle();
        shape.Draw();
        Animal Dog = new Dog();
        Console.WriteLine(Dog.Sound);
        Console.WriteLine(Dog.age);
        Library library = new SpecialLibrary();
        library[0] = "C# Programming";
        Console.WriteLine(library[0]);
    }
}

