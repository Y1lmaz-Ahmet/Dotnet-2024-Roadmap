using System;

public class PublicClass
{
    // Public characteristics
    public string PublicProperty { get; set; } = "";
    // Public Method
    public void PublicMethod()
    {
        Console.WriteLine("This is a public method.");
    }
}
// Internal class with a internal method
internal class InternalClass
{
    // Internal characteristics
    internal string InternalProperty { get; set; } = "";
    // Internal Method
    internal void InternalMethod()
    {
        Console.WriteLine("This is an internal method.");
    }
}
// Private class with a private method
// By default; if no acces modifier is given to a class  = acces modifier is set to 'internal' !!!
class PrivateClass
{
    // Private characteristics
    private string PrivateProperty { get; set; } = "";
    // Private Method
    private void PrivateMethod()
    {
        Console.WriteLine("This is a private method.");
    }
    // Method to call the private method from outside the source code
    public void CallPrivateMethod()
    {
        Console.WriteLine("Calling private method from withing the class:"); ;
        PrivateMethod();
    }
}

class Program
{
    static void Main()
    {
        // Instances of the different classes
        PublicClass publicObj = new PublicClass();
        InternalClass internalObj = new InternalClass();
        PrivateClass privateObj = new PrivateClass();

        // Access to the public class and method
        publicObj.PublicProperty = "Public Property Value";
        publicObj.PublicMethod();
        Console.WriteLine();

        // Access to the internal class and method
        internalObj.InternalProperty = "Internal Property Value";
        internalObj.InternalMethod();
        Console.WriteLine();

        // Access the private class and method via a public method
        privateObj.CallPrivateMethod();
    }
}