using System;

class Car
{
    /*Make a Car Object with 3 properties ( Brand, Model, Price )
      This class does need to have TWO ways of creating a car object
      Find a way to show the made object in the console
    */

    // Properties
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Price { get; set; }
    //Ctor to initialize a car object on the same line without dot notation
    public Car(string brand, string model, double price)
    {
        Brand = brand;
        Model = model;
        Price = price;
    }
    //Ctor to create a car object to initialize it later with dot notation
    public Car()
    {
        
    }

    // Printing car details
    public void PrintCarDetails()
    {
        Console.WriteLine($"[BRAND]:{Brand}\n\t[MODEL]:{Model}\n\t[PRICE]:{Price}\n");
    }
}
class Program
{
    static void Main()
    {
        // Car WITH ctor
        Car carWithCtor = new Car("Mercedes","GLA",85600);
        // Print car details
        carWithCtor.PrintCarDetails();
        // Car WITHOUT ctor
        Car carWithoutCtor = new Car();
        carWithoutCtor.Brand = "Porche";
        carWithoutCtor.Model = "Boxster";
        carWithoutCtor.Price = 78500;
        // Print car details
        carWithoutCtor.PrintCarDetails();
    }
}
