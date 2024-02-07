using CalculatorAssembly;
using PrintAssembly;

namespace _04_L_Assemblies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use the SimpleCalculator class from CalculatorAssembly
            SimpleCalculator calculator = new SimpleCalculator();
            int result = calculator.Add(10, 5);
            Console.WriteLine($"Result of addition: {result}");

            // Use the ConsolePrinter class from PrinterAssembly
            ConsolePrinter printer = new ConsolePrinter();
            printer.PrintMessage("Hello from ConsolePrinter class!");
        }
    }
}
