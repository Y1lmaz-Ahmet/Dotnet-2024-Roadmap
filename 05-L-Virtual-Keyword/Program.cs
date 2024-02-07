using System;

// Shape class represents a basic geometric shape.
public class Shape
{
    // Draw method is marked as virtual to allow for overriding in derived classes.
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}

// Circle class inherits from Shape and overrides the Draw method.
public class Circle : Shape
{
    // Draw method is overridden to provide a specific implementation for circles.
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

// Animal class represents a generic animal with virtual properties.
public class Animal
{
    // Sound property returns a generic animal sound.
    public virtual string Sound => "Generic animal sound.";

    // Age property returns 0 by default.
    public virtual int Age => 0;
}

// Dog class inherits from Animal and overrides the Sound and Age properties.
public class Dog : Animal
{
    // Sound property is overridden to provide a specific sound for dogs.
    public override string Sound => "Bark!";

    // Age property is overridden to provide a specific age for dogs.
    public override int Age => 9;
}

// Library class represents a basic library with a virtual indexer for books.
public class Library
{
    private string[] books = new string[5]; // 5 = length

    // Indexer allows getting and setting book titles.
    public virtual string this[int index]
    {
        get => books[index];
        set => books[index] = value;
    }
}

// SpecialLibrary class inherits from Library and overrides the indexer.
public class SpecialLibrary : Library
{
    // Indexer is overridden to modify the behavior of the base class indexer.
    public override string this[int index]
    {
        get => $"Special: {base[index]}";
        set => base[index] = value;
    }
}

// Program class contains the Main method where the code execution starts.
class Program
{
    static void Main()
    {
        // Creating an instance of Circle and assigning it to a Shape variable.
        Shape shape = new Circle();
        shape.Draw(); // Calls the overridden Draw method for circles.

        // Creating an instance of Dog and assigning it to an Animal variable.
        Animal dog = new Dog();
        Console.WriteLine(dog.Sound); // Outputs the overridden sound for dogs.
        Console.WriteLine(dog.Age);   // Outputs the overridden age for dogs.

        // Creating an instance of SpecialLibrary and using the overridden indexer.
        Library library = new SpecialLibrary();
        library[0] = "C# Programming"; // Sets a book title using the overridden indexer.
        Console.WriteLine(library[0]);  // Gets the modified book title using the overridden indexer.
    }
}
