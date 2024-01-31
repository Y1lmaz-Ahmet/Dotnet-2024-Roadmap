# Parameter Types in C#

## Overview

Understanding parameter types is essential in C# programming, as it dictates how information is passed to methods. This README provides an in-depth explanation of various parameter types, including pass by value, pass by reference, output parameters, and parameter arrays.

## Pass by Value
![PassByValue](https://github.com/Y1lmaz-Ahmet/Dotnet-2024-Roadmap/blob/master/Parameter-Types/example-images/PassByValue.png)

### Overview

- **What Happens?**
  - A copy of the value of the argument is sent to the method.
  - Changes within the method do not affect the original value outside the method.

- **When to Use:**
  - Use when you want to preserve the original value outside the method.

## Pass by Reference
![PassByReference](https://github.com/Y1lmaz-Ahmet/Dotnet-2024-Roadmap/blob/master/Parameter-Types/example-images/PassByReference.png)
### Overview

- **What Happens?**
  - The memory address of the argument is sent to the method.
  - Changes within the method directly affect the original value outside the method.

- **When to Use:**
  - Use when you want changes in the method to affect the original value outside the method.

## Output Parameters
![PassByOutput](https://github.com/Y1lmaz-Ahmet/Dotnet-2024-Roadmap/blob/master/Parameter-Types/example-images/PassByOutput.png)
### Overview

- **What Happens?**
  - Similar to pass by reference, but the parameter doesn't need to be initialized before calling the method.
  - The method is responsible for assigning a value to the parameter.

- **When to Use:**
  - Use when you want a method to return a value, and the parameter doesn't need to be initialized before the method is called.

## Parameter Arrays
![UseParams](https://github.com/Y1lmaz-Ahmet/Dotnet-2024-Roadmap/blob/master/Parameter-Types/example-images/UseParams.png)
### Overview

- **What Happens?**
  - Allows a method to accept a variable number of arguments using the `params` keyword.

- **When to Use:**
  - Use when you want a method to accept different numbers of arguments.

## Configuration
![Configuration](https://github.com/Y1lmaz-Ahmet/Dotnet-2024-Roadmap/blob/master/Parameter-Types/example-images/example-configuring.png)
## Conclusion

Understanding these parameter types is crucial for effective C# programming. Each type serves a specific purpose, and choosing the right one depends on the requirements of your methods. Experiment with different scenarios to gain a practical understanding of how each type behaves.

