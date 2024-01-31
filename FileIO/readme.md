# File Input/Output (I/O) in C#

File Input/Output (I/O) in C# is a crucial aspect of working with external data. This README provides an overview of basic File I/O concepts, covering both reading from and writing to files.

## Overview

File I/O involves interacting with files, including creating, reading, updating, and deleting data within them. Understanding these operations is essential for handling various data storage scenarios.

## Reading and Writing to Text Files

### Creating a File Path

Before working with files, you need to specify the file path, including the folder path and the file name.

### Writing to a Text File

To write to a file, you can use `StreamWriter`. In the provided example, a text file named `example.txt` is created with sample text.

### Reading from a Text File

To read from a file, you can use `StreamReader`. In the example, the content of `example.txt` is read and displayed in the console.

## Working with XML Files

### Loading an XML Document

Working with XML files often involves loading the file into an XML document using `XDocument`. In the example, an XML document named `persons.xml` is loaded.

### Parsing XML Data

Once loaded, you can parse XML data into objects using `XDocument.Descendants`. In the example, data from `persons.xml` is parsed into a list of `Person` objects.

### Using `Person` Objects

The list of `Person` objects is then iterated, and each person's details, including name, age, and city, are printed to the console.

## Conclusion

Understanding File I/O in C# is crucial for handling data persistence. Whether working with text files or XML, these foundational concepts provide the necessary tools for effective file manipulation.
