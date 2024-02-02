using System;

class Hero
{
    // Constructor to create a hero.
    public Hero(string name, int level, int strength, double height, int speed)
    {
        Name = name;
        Level = level;
        Strength = strength;
        Height = height;
        Speed = speed;
    }
    // Properties of a hero
    public string Name { get; set; } = "";
    public int Level { get; set; }
    public int Strength { get; set; }
    public double Height { get; set; }
    public int Speed { get; set; }

    // Method to print hero details
    public void PrintInfo()
    {
        Console.WriteLine($"Hero: {Name}, Level: {Level}");
        Console.WriteLine($"Strength: {Strength}, Height: {Height} meters, Speed: {Speed} km/h\n");
    }

}

class Program
{
    static void Main()
    {
        // Instance of the Hero class 👇
        Hero hero1 = new Hero("Superman", 10, 90, 1.95, 100);
        Hero hero2 = new Hero("Batman", 8, 70, 1.82, 80);
        Hero hero3 = new Hero("Wonder Woman", 12, 80, 1.78, 120);
        // Printing hero details
        hero1.PrintInfo();
        hero2.PrintInfo();
        hero3.PrintInfo();
        

        // Looping through new hero's and printing hero info in one go.
        List<Hero> heroes = new List<Hero>
        {
            hero1, hero2, hero3
        };
        // Loop to print individual hero detail from start to end of the list
        // Adding virtual index.
        Console.WriteLine("looping through heroes with a foreach");
        int heroesListIndex = 0;
        foreach(Hero hero in heroes)
        {
            Console.Write($"[HEROESlist]:{hero.Name} found on index {heroesListIndex}\t");
            hero.PrintInfo();
            heroesListIndex++;
        }
        Console.ReadLine();
    }
}
