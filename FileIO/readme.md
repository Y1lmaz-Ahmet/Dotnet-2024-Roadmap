# File Input/Output (I/O) in C#

File Input/Output (I/O) in C# is a crucial aspect of working with external data. This README provides an overview of basic File I/O concepts, covering both reading from and writing to files.

## Overview

File I/O involves interacting with files, including creating, reading, updating, and deleting data within them. Understanding these operations is essential for handling various data storage scenarios.

## Reading and Writing to Text Files

### Creating a File Path

Before working with files, you need to specify the file path, including the folder path and the file name.
```     //Combine folder path and file name to get the full file path for the text file
        string folderPath = Path.Combine("C:", "Users", "Yilmaz", "source", "repos", "Dotnet-2024-Roadmap", "FileIO");
        string fileName = "example.txt";
        string filePath = Path.Combine(folderPath, fileName); 
```

### Writing to a Text File

To write to a file, you can use `StreamWriter`. In the provided example, a text file named `example.txt` is created with sample text.
```         // Write to the file using StreamWriter
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Hello, this is a sample text V2.0");
                writer.Write("My Name is Ahmet Yilmaz and I'm learning file IO basic concepts right now.");
            }
```
### Reading from a Text File

To read from a file, you can use `StreamReader`. In the example, the content of `example.txt` is read and displayed in the console.
```         // Read the file using StreamReader
            Console.WriteLine($"Content of the file '{fileName}':");
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
```
## Working with XML Files

### Defining path of the XML Document
```
        // Define paths for the XML document
        string Folderpath = Path.Combine("C:", "Users", "Yilmaz", "source", "repos", "Dotnet-2024-Roadmap", "FileIO");
        string XMLDocumentName = "persons.xml";
        string documentPath = Path.Combine(Folderpath, XMLDocumentName);
```

### Loading an XML Document

Working with XML files often involves loading the file into an XML document using `XDocument`. In the example, an XML document named `persons.xml` is loaded.
```
        // Load the XML document
        XDocument XMLDocument = XDocument.Load(documentPath);
```
### Parsing XML Data

Once loaded, you can parse XML data into objects using `XDocument.Descendants`. In the example, data from `persons.xml` is parsed into a list of `Person` objects.
```
        // Parse XML data into a list of Person objects
        List<Person> persons = XMLDocument.Descendants("Person").Select(human => new Person(
            human.Element("Name").Value,
            Convert.ToInt32(human.Element("Age").Value),
            human.Element("City").Value))
        .ToList();
```
### Using `Person` Objects

The list of `Person` objects is then iterated, and each person's details, including name, age, and city, are printed to the console.
```
// Iterate through the list of persons and print their details
        int listPersonCounter = 1;
        foreach (Person person in persons)
        {
            Console.WriteLine($"person in list: {listPersonCounter}");
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.City);
            Console.WriteLine("---");
            listPersonCounter++;
        }
```
## Conclusion

Understanding File I/O in C# is crucial for handling data persistence. Whether working with text files or XML, these foundational concepts provide the necessary tools for effective file manipulation.
