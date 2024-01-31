# Generics in C#

Generics in C# provide a powerful way to write flexible and reusable code that can work with different data types. This README provides an overview of the concept of generics using a simple example.

## Introduction to Generics

Generics allow you to define `classes`, `interfaces`, `methods`, and `delegates` with **placeholders** for the data type they operate on. This enables you to create code that is not bound to a specific data type and promotes code reusability.

## `Human<T>` Class

In the provided example, there's a generic class named `Human<T>`. This class represents a human with a name and an age. The age is defined as a generic type `T`, allowing it to be of any data type.

``` public class Human<T>
{
    public string Name { get; set; }
    public T Age { get; set; }
    public Human(string name, T age)
    {
        Name = name;
        Age = age;
    }
    public void Talk()
    {
        Console.WriteLine($"Hello, I'm {Name} and I'm {Age} years old.");
        
    }
}
```
### Properties

- **Name:** Represents the name of the human.
- **Age:** Represents the age of the human and is of type `T`.

### Constructor

The class has a constructor that takes a name (string) and an age (of type `T`) as parameters.

### Method: `Talk()`

The `Talk` method prints a message to the console, including the human's name and age.

## Using `Human<T>` in `Program`

The `Program` class demonstrates how to use the `Human<T>` class with different data types.

### Example Usage
``` class Program
{
    static void Main()
    {
        //Human with age = integer
        Human<int> HumanWithIntegerAge = new Human<int>("John Doe", 36);
        HumanWithIntegerAge.Talk();
        //Human with age = string
        Human<string> HumanWithStringAge = new Human<string>("Filip boo", "54");
        HumanWithStringAge.Talk();
        Console.ReadKey();
    }
}
```

- An instance of `Human<int>` is created with an integer age.
- Another instance of `Human<string>` is created with a string age.

### Key Points

- The flexibility of the `Human<T>` class allows you to create instances with various data types for the age property.
- The `Talk` method can be used consistently regardless of the data type of the age.

## Conclusion

Generics enhance code flexibility and maintainability by allowing you to write code that is not tied to specific data types. The `Human<T>` example showcases how generics provide a way to create reusable and versatile components within C# programs.
