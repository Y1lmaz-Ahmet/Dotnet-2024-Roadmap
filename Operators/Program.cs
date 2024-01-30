using System;

class Program
{
     static void Main()
    {
        // The goal of this console project is to refresh Operators
        // #1 : Arithmetic Operators
        // #2 : Comparison Operators

        // Make two variables with a type of 'integer' a & b 
        int a = 5;
        int b = 3;
        Console.WriteLine("\t\tArithmetic operators\n");
        // Addition
        int sum = a + b;
        Console.WriteLine($"[ADDITION] => {nameof(sum)}: {a} + {b} = {sum}");
        // Subtraction
        int difference = a - b;
        Console.WriteLine($"[SUBTRACTION] => {nameof(difference)}: {a} - {b} = {difference}");
        // Multiplication
        int product = a * b;
        Console.WriteLine($"[MULTIPLICATION] => {nameof(product)}: {a} * {b} = {product}");
        // Division
        int quotient = a / b;
        Console.WriteLine($"[DIVISION] => {nameof(quotient)}: {a} / {b} = {quotient}");
        // Modulus
        int remainder =  a % b;
        Console.WriteLine($"[MODULUS] => {nameof(remainder)}: {a} % {b} = {remainder}");
        Console.WriteLine("\n\t\tComparison operators\n");
        int x = 10;
        int y = 20;
        Console.WriteLine($"[VARIABLE VALUES]:\tx= {x}\ty= {y} \n");
        bool isEqual = (x == y);   // Equal to
        Console.WriteLine($"[EQUAL TO] => {nameof(isEqual)}: x == y output is  {isEqual}");
        bool isNotEqual = (x != y); // Not equal to
        Console.WriteLine($"[IS NOT EQUAL TO] => {nameof(isNotEqual)}: x != y output is  {isNotEqual}");
        bool isGreaterThan = (x > y);   // Greater than
        Console.WriteLine($"[IS GREATER THAN] => {nameof(isGreaterThan)}: x > y output is  {isGreaterThan}");
        bool isLessThan = (x < y);  // Less than
        Console.WriteLine($"[IS LESS THAN] => {nameof(isLessThan)}: x < y output is  {isLessThan}");
        bool isGreaterOrEqual = (x >= y);   // Greater than or equal to
        Console.WriteLine($"[IS GREATER OR EQUAL] => {nameof(isGreaterOrEqual)}: x >= y output is  {isGreaterOrEqual}");
        bool isLessOrEqual = (x <= y);  // Less than or equal to
        Console.WriteLine($"[IS LESS OR EQUAL] => {nameof(isLessOrEqual)}: x <= y output is  {isLessOrEqual}");
    }
}