using System;

class Program
{
    static void Main()
    {
        // Declare a variable to store the result
        int result;

        // Calling the AddNumber method with operands 5 and 10
        // The result is returned through the 'out' parameter 'result'
        AddNumber(5, 10, out result);

        // Display the result of the addition
        Console.WriteLine("[ADDING]: The result is: " + result);

        // Calling the SubtractNumbers method with operands 69 and 60
        // The result is returned through the 'out' parameter 'result'
        SubtractNumbers(69, 60, out result);

        // Display the result of the subtraction
        Console.WriteLine("[SUBTRACTING]: The result is: " + result);
    }

    // Method to add two numbers and return the result through an 'out' parameter
    static void AddNumber(int operand1, int operand2, out int sum)
    {
        // Calculate the sum of the operands
        sum = operand1 + operand2;
    }

    // Method to subtract one number from another and return the result through an 'out' parameter
    static void SubtractNumbers(int operand1, int operand2, out int subtractedValue)
    {
        // Calculate the difference between the operands
        subtractedValue = operand1 - operand2;
    }
}
