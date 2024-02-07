// Parameter types
using System;
public class ParameterTypesExample
{
    /* When you pass a parameter by value, you are essentially sending a copy
     * of the value to the method. Any changes made to the parameter inside
     * the method do not affect the original value outside the method.
    */
    public void PassByValue(int number)
    {
        // Inside this method, 'number' is 10, but outside, it remains unchanged.
        number = 10;
        Console.WriteLine("Inside PassByValue: " + number);
    }

    /* When you pass a parameter by reference using the ref keyword,
     * you are sending the actual memory address of the variable to
     * the method. Any changes made to the parameter inside the method
     * directly affect the original value outside the method.
     */
    public void PassByReference(ref int number)
    {
        // Inside this method, 'number' is 20, and outside, the original variable is also changed to 20.
        number = 20;
        Console.WriteLine("Inside PassByReference: " + number);
    }

    /* Passing a parameter by output using the out keyword is similar to
     * passing by reference, but the key difference is that the parameter
     * doesn't need to be initialized before calling the method. The method
     * is responsible for assigning a value to the parameter.
     */
    public void PassByOutput(out int number)
    {
        // Inside this method, 'number' is 30, and outside, the original variable is set to 30.
        number = 30;
        Console.WriteLine("Inside PassByOutput: " + number);
    }

    /* A parameter array allows a method to accept a variable number of arguments. The params
     * keyword is used for this purpose.
     */
    public void UseParams(params string[] names)
    {
        Console.WriteLine("Parameter array elements:");
        // 'names' is an array that contains the provided arguments.
        // It allows the method to accept different numbers of strings.
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }

    static void Main()
    {
        ParameterTypesExample example = new ParameterTypesExample();
        int value = 5;
        example.PassByValue(value);
        Console.WriteLine("Outside PassByValue: " + value);

        example.PassByReference(ref value);
        Console.WriteLine("Outside PassByReference: " + value);

        example.PassByOutput(out value);
        Console.WriteLine("Outside passByOutput: " + value);

        example.UseParams("Alice", "Bob", "Charlie", "Femke", "Pieter");
    }

}

