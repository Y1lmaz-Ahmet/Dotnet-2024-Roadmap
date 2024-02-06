// Examples of Encapsulation:

// #1: Student class with validation on length of name property.
public class Student
{
    private string name = "name not set";
    public string Name
    {
        get { return name; }
        set
        {
            // Add validation: name must be at least 2 characters long
            if (value.Length >= 2 && (value != "name not set"))
            {
                name = value;
            }
        }
    }
}

// #2: Car class with validation of mileage.
public class Car
{
    private int mileage;
    public int Mileage
    {
        get { return mileage; }
        set
        {
            if (value <= 0)
            {
                mileage = value;
            }
        }
    }
}

// #3: Book class with page validation to check if page is not below 0.
public class Book
{
    private int bookPage;
    public int BookPage
    {
        get { return bookPage; }
        set
        {
            if (value >= 0)
            {
                bookPage = value;
            }
        }
    }
}

// #4: Temperature Conversion Class with Temperature Validation.
public class TemperatureConverter
{
    private double celsius;
    public double Celsius
    {
        get { return celsius; }
        set
        {
            // Temperature cannot be lower than absolute zero
            if (value >= -273.15)
            {
                celsius = value;
            }
        }
    }
    // Method to convert Celsius to Fahrenheit.
    public double CelciusToFahrenheit(double value)
    {
        return (value * 9 / 5) + 32;
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of TemperatureConverter class.
        TemperatureConverter converter = new TemperatureConverter();
        // Converting Celsius to Fahrenheit and printing the result.
        Console.WriteLine(converter.CelciusToFahrenheit(converter.Celsius = 30));
    }
}
