# Console App with Access Modifiers in C#

This console application demonstrates the usage of different access modifiers in C#.

## PublicClass

The `PublicClass` is marked as public, making its members accessible from anywhere in the program and other assemblies.

- **PublicProperty:** A public property with a getter and setter.
- **PublicMethod():** A public method that can be called from any part of the program.

### Public Access Modifier

The `public` access modifier is the least restrictive. Members marked as public are accessible from any other part of the program or even from external assemblies. This makes them suitable for components that need to be widely accessible.

## InternalClass

The `InternalClass` is marked as internal, restricting access to the current assembly.

- **InternalProperty:** An internal property with a getter and setter.
- **InternalMethod():** An internal method that is accessible only within the same assembly.

### Internal Access Modifier

The `internal` access modifier limits the visibility of members to the same assembly. This provides a level of encapsulation within the assembly, making internal details hidden from external assemblies. It is useful for components that are meant to be used within a specific project or library.

## PrivateClass

The `PrivateClass` doesn't have an explicit access modifier, so it defaults to internal. However, it's documented here to illustrate the point.

- **PrivateProperty:** A private property with a getter and setter.
- **PrivateMethod():** A private method that is only accessible within the class.
- **CallPrivateMethod():** A public method that calls the private method internally.

### Private Access Modifier

The `private` access modifier is the most restrictive. Members marked as private are accessible only within the same class. This level of encapsulation is useful for hiding implementation details and ensuring that certain parts of the code are not accessible from the outside.

Feel free to experiment with the code and observe how the different access modifiers affect the visibility of classes and their members.
