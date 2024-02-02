# OOP - 1 - Classes

In this object-oriented programming (OOP) exercise, we've created a simple C# program to model and display information about different heroes. Let's break down what I have implemented and what I aimed to achieve.

## Hero Class


### Properties
- **Name:** Represents the name of the hero.
- **Level:** Indicates the hero's level.
- **Strength:** Reflects the hero's strength.
- **Height:** Represents the height of the hero in meters.
- **Speed:** Denotes the hero's speed in km/h.
```csharp
    public string Name { get; set; } = "";
    public int Level { get; set; }
    public int Strength { get; set; }
    public double Height { get; set; }
    public int Speed { get; set; }
```

### Constructor
- The `Hero` class has a constructor that allows the creation of a hero instance with specific attributes.
```csharp
public Hero(string name, int level, int strength, double height, int speed)
    {
        Name = name;
        Level = level;
        Strength = strength;
        Height = height;
        Speed = speed;
    }
```

### Method
- `PrintInfo()`: This method prints detailed information about the hero, including name, level, strength, height, and speed.
```csharp
public void PrintInfo()
    {
        Console.WriteLine($"Hero: {Name}, Level: {Level}");
        Console.WriteLine($"Strength: {Strength}, Height: {Height} meters, Speed: {Speed} km/h\n");
    }
```
## Program Class

- **Main Method:**
  - Creates three instances of the `Hero` class (`hero1`, `hero2`, and `hero3`) with different attributes.
```csharp
      Hero hero1 = new Hero("Superman", 10, 90, 1.95, 100);
            Hero hero2 = new Hero("Batman", 8, 70, 1.82, 80);
            Hero hero3 = new Hero("Wonder Woman", 12, 80, 1.78, 120);
```
  - Calls the `PrintInfo()` method for each hero to display their details individually.
```csharp
         hero1.PrintInfo();
                hero2.PrintInfo();
                hero3.PrintInfo();
```
- **List and Foreach Loop:**
  - Creates a list (`heroes`) containing the previously created heroes.
  ```csharp
    List<Hero> heroes = new List<Hero>
        {
            hero1, hero2, hero3
        };
    ```
  - Includes an index to track the position of each hero in the list.
```csharp
    int heroesListIndex = 0;
```
    - Uses a `foreach` loop to iterate through the list and print each hero's details.
```csharp
         foreach(Hero hero in heroes)
        {
            Console.Write($"[HEROESlist]:{hero.Name} found on index {heroesListIndex}\t");
            hero.PrintInfo();
            heroesListIndex++;
        }
```

## Conclusion

In this exercise, I practiced creating a class (`Hero`) with properties, a constructor, and a method. I instantiated objects of this class, printed their details individually, and then iterated through a list of heroes, printing their information in a concise manner. The exercise provides a foundation for understanding how to structure classes, use constructors, and leverage methods in an object-oriented programming paradigm.
