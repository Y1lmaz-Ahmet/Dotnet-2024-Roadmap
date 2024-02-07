public class Human<T>
{
    public string Name { get; set; }
    public T Age { get; set; }
    public Human(string name, T age)
    {
        Name = name;
        Age = age;
    }
    public void Talk()
    {
        Console.WriteLine($"Hello, I'm {Name} and I'm {Age} years old.");

    }
}
class Program
{
    static void Main()
    {
        //Human with age = integer
        Human<int> HumanWithIntegerAge = new Human<int>("John Doe", 36);
        HumanWithIntegerAge.Talk();
        //Human with age = string
        Human<string> HumanWithStringAge = new Human<string>("Filip boo", "54");
        HumanWithStringAge.Talk();
        Console.ReadKey();
    }
}
