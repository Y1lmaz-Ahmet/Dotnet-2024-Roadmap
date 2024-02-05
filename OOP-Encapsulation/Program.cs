// Examples of Encapsulation :
// #1: Student class with validation on length of name property.
public class Student
{
    private string name = "name not set";
    public string Name
    {
        get { return name; }
        set
        {
            // Voeg validatie toe: naam moet minstens 2 tekens bevatten
            if (value.Length >= 2 && (value != "name not set"))
            {
                name = value;
            }
        }
    }
}
// #2: Car class with validation of mileage
public class Car
{
    private int mileage;
    public int Mileage
    {
        get { return mileage; }
        set
        {
            if ( value <= 0)
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
// #4: Temperature Conversion Class with Temperature Validation
public class TemperatureConverter
{
    private double celsius;
    public double Celsius
    {
        get { return celsius; }
        set
        {
            // temperature cannot be lower than absolute zero
            if (value >= -273.15)
            {
                celsius = value;
            }
        }
    }
    public double CelciusToFahrenheit(double value)
    {
        return (value * 9 / 5) + 32; 
    }
}
class Program
{
    static void Main()
    {
        TemperatureConverter converter = new TemperatureConverter();
        Console.WriteLine(converter.CelciusToFahrenheit(converter.Celsius = 30));
    }
}