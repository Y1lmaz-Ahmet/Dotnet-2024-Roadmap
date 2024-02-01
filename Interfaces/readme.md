# Learning C# Interfaces

## Overview

This repository is dedicated to understanding and practicing the concept of interfaces in C#. Interfaces provide a way to define contracts for classes, ensuring that certain methods and properties are implemented.

## Table of Contents

1. [What are Interfaces?](#what-are-interfaces)
2. [Why Use Interfaces?](#why-use-interfaces)
3. [Declaring and Implementing Interfaces](#declaring-and-implementing-interfaces)
4. [Example Usage](#example-usage)

## What are Interfaces?

An interface in C# is a contract that defines a set of methods and properties. Any class that implements an interface must provide concrete implementations for all the methods and properties declared in that interface.

## Why Use Interfaces?

- **Enforce Contracts:** Interfaces ensure that classes adhering to them provide specific functionality, enforcing a contract.

- **Achieve Polymorphism:** Interfaces enable polymorphism, allowing objects of different classes to be treated interchangeably if they implement the same interface.

- **Improve Code Maintainability:** By using interfaces, you can decouple the implementation details from the interface, making your code more modular and maintainable.

## Declaring and Implementing Interfaces

To declare an interface, use the `interface` keyword. Classes then implement the interface using the `class : interface` syntax.

```csharp
public interface IDrawable
{
    void Draw();
}
```

## How to use an `interface` with a class 

```csharp
// [Access Modifier (public, private, internal, protected)] [Class Name] : [Interface Name]
public class Circle : IDrawable
{
    // Implementation of methods and properties required by the IDrawable interface
    public void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }

    // Additional members specific to the Circle class can be defined here
}

```
```csharp
// [Access Modifier (public, private, internal, protected)] [Class Name] : [Interface Name]
public class Square : IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
}
```

```csharp
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
```
