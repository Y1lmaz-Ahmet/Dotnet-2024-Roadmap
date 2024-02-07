using System;

class Program
{
    static void Main()
    {
        // Implicit casting: changing types by assigning variable a to variable b where b has another type

        // Example 1: Implicit casting from int to long
        int intValue = 42;
        long longValue = intValue; // Implicit casting an int to long
        Console.WriteLine($"Implicit Casting - int to long: {longValue}");

        // Example 2: Implicit casting from float to double
        float floatValue = 3.14f;
        double doubleValueFromFloat = floatValue; // Implicit casting from float to double
        Console.WriteLine($"Implicit Casting - float to double: {doubleValueFromFloat}");

        // Explicit casting: variable a = 3.14 => variable b = (casting type)variable a

        // Example 3: Explicit casting from double to int
        double doubleValue = 3.14;
        int truncatedValue = (int)doubleValue; // Explicit casting from double to integer
        Console.WriteLine($"Explicit Casting - double to int: {truncatedValue}");

        // Example 4: Explicit casting from decimal to int
        decimal decimalValue = 123.45m;
        int intValueFromDecimal = (int)decimalValue; // Explicit casting from decimal to int
        Console.WriteLine($"Explicit Casting - decimal to int: {intValueFromDecimal}");

        // Example 5: Explicit casting from char to int
        char charValue = 'A';
        int intValueFromChar = (int)charValue; // Explicit casting from char to int
        Console.WriteLine($"Explicit Casting - char to int: {intValueFromChar}");

        // Example 6: Explicit casting from long to int (potential data loss)
        long bigLongValue = 9876543210;
        int intValueFromLong = (int)bigLongValue; // Explicit casting from long to int (potential data loss)
        Console.WriteLine($"Explicit Casting - long to int (potential data loss): {intValueFromLong}");

        // Value Types

        // Integral Types
        byte byteValue = 255;
        sbyte sbyteValue = -128;
        short shortValue = -32768;
        ushort ushortValue = 65535;
        int intValueForTypes = 2147483647;
        uint uintValue = 4294967295;
        long longValueForTypes = 9223372036854775807;
        ulong ulongValue = 18446744073709551615;

        // Floating-Point Types
        float floatValueForTypes = 3.14f;
        double doubleValueForTypes = 3.141592653589793;

        // Decimal Type
        decimal decimalValueForTypes = 123.456m;

        // Character Type
        char charValueForTypes = 'A';

        // Boolean Type
        bool boolValue = true;

        // Output the values for value types
        Console.WriteLine($"byteValue: {byteValue}");
        Console.WriteLine($"sbyteValue: {sbyteValue}");
        Console.WriteLine($"shortValue: {shortValue}");
        Console.WriteLine($"ushortValue: {ushortValue}");
        Console.WriteLine($"intValueForTypes: {intValueForTypes}");
        Console.WriteLine($"uintValue: {uintValue}");
        Console.WriteLine($"longValueForTypes: {longValueForTypes}");
        Console.WriteLine($"ulongValue: {ulongValue}");
        Console.WriteLine($"floatValueForTypes: {floatValueForTypes}");
        Console.WriteLine($"doubleValueForTypes: {doubleValueForTypes}");
        Console.WriteLine($"decimalValueForTypes: {decimalValueForTypes}");
        Console.WriteLine($"charValueForTypes: {charValueForTypes}");
        Console.WriteLine($"boolValue: {boolValue}");
    }
}
