# Polymorphism Example in C#

The provided C# code demonstrates the use of polymorphism by defining an abstract class `Shape` and implementing two derived classes `Circle` and `Rectangle`.

## Abstract Class `Shape`

- `Shape` is an abstract class containing an abstract method `CalculateArea()`.
- The `CalculateArea` method must be implemented by any class that `inherits` from `Shape`.

## Class `Circle` (Inheriting from `Shape`)

- `Circle` is a child class of `Shape`.(**Inheritance**)
- It has a property `Radius` and a constructor to initialize it.
- The `CalculateArea` method is overridden to calculate the area of a circle using the formula π * radius^2.

## Class `Rectangle` (Inheriting from `Shape`)

- `Rectangle` is another child class of `Shape`.
- It has properties `Width` and `Height` along with a constructor.
- The `CalculateArea` method is overridden to calculate the area of a rectangle using the formula width * height.

## Main Program

- In the `Main` method, a list of `Shape` objects is created, including instances of `Circle` and `Rectangle`.
- A `foreach` loop is used to iterate through the list and print the type and area of each shape.
- The `GetType().Name` method is utilized to get the actual type of each shape.
- The `:F2` format specifier ensures that the area is displayed with exactly two decimal places(check line 57).


