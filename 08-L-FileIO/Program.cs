using System;
using System.IO;
using System.Xml.Linq;

class Program
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        // Constructor for the Person class
        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }

        // Method to print details of the person
        public void PrintPersonDetails()
        {
            Console.WriteLine($"Hello, my name is {Name}.\nI'm {Age} years old.\nI live in {City}");
        }
    }

    static void Main()
    {
        // Combine folder path and file name to get the full file path for the text file
        string folderPath = Path.Combine("C:", "Users", "Yilmaz", "source", "repos", "Dotnet-2024-Roadmap","08-L-FileIO");
        string fileName = "example.txt";
        string filePath = Path.Combine(folderPath, fileName);

        try
        {
            // Check if the file already exists
            if (File.Exists(filePath))
            {
                Console.WriteLine($"File with the name '{fileName}' already exists and will now be deleted...");

                // Delete the file
                File.Delete(filePath);

                // Check if the file was successfully deleted
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File '{fileName}' has been successfully deleted.");
                }
                else
                {
                    Console.WriteLine($"Couldn't delete the file '{fileName}'.");
                    return;
                }
            }

            // Write to the file using StreamWriter
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Hello, this is a sample text V3.0");
                writer.Write("My Name is Ahmet Yilmaz and I'm learning file IO basic concepts right now.");
            }

            // Read the file using StreamReader
            Console.WriteLine($"Content of the file '{fileName}':");
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        // Define paths for the XML document
        string Folderpath = Path.Combine("C:", "Users", "Yilmaz", "source", "repos", "Dotnet-2024-Roadmap", "08-L-FileIO");
        string XMLDocumentName = "persons.xml";
        string documentPath = Path.Combine(Folderpath, XMLDocumentName);

        // Load the XML document
        XDocument XMLDocument = XDocument.Load(documentPath);

        // Parse XML data into a list of Person objects
        List<Person> persons = XMLDocument.Descendants("Person").Select(human => new Person(
            human.Element("Name").Value,
            Convert.ToInt32(human.Element("Age").Value),
            human.Element("City").Value))
        .ToList();

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
    }
}
