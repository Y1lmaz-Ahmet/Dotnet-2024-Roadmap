using System;
using System.Collections.Generic;
using System.Collections;

class Program
{
    static void Main()
    {
        // Arrays
        int[] numbersArray = { 1, 2, 3, 4, 5 };

        // Lists
        List<string> namesList = new List<string> { "Alice", "Bob", "Charlie" };
        namesList.Add("David");

        // Dictionaries
        Dictionary<string, int> agesDictionary = new Dictionary<string, int>
        {
            { "Alice", 25 },
            { "Bob", 30 },
            { "Charlie", 35 }
        };

        // Sets
        HashSet<int> uniqueNumbersSet = new HashSet<int> { 1, 2, 3, 4, 5, 1 };

        // Queues
        Queue<string> waitingQueue = new Queue<string>();
        waitingQueue.Enqueue("Person1");
        waitingQueue.Enqueue("Person2");
        string nextPerson = waitingQueue.Dequeue();

        // Stacks
        Stack<string> bookStack = new Stack<string>();
        bookStack.Push("Book1");
        bookStack.Push("Book2");
        string topBook = bookStack.Pop();

        // LinkedLists
        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.AddLast(10);
        linkedList.AddLast(20);
        linkedList.AddLast(30);

        // ArrayLists
        ArrayList mixedList = new ArrayList();
        mixedList.Add("String");
        mixedList.Add(123);
        mixedList.Add(true);

        // Displaying values
        Console.WriteLine("Array:");
        foreach (var num in numbersArray)
        {
            Console.Write($"{num} ");
        }

        Console.WriteLine("\n\nList:");
        foreach (var name in namesList)
        {
            Console.Write($"{name} ");
        }

        Console.WriteLine("\n\nDictionary:");
        foreach (var pair in agesDictionary)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value} years old");
        }

        Console.WriteLine("\n\nSet:");
        foreach (var num in uniqueNumbersSet)
        {
            Console.Write($"{num} ");
        }

        Console.WriteLine("\n\nQueue:");
        Console.WriteLine($"Next person: {nextPerson}");

        Console.WriteLine("\nStack:");
        Console.WriteLine($"Top book: {topBook}");

        Console.WriteLine("\nLinkedList:");
        foreach (var num in linkedList)
        {
            Console.Write($"{num} ");
        }

        Console.WriteLine("\n\nArrayList:");
        foreach (var item in mixedList)
        {
            Console.Write($"{item} ");
        }
    }
}
