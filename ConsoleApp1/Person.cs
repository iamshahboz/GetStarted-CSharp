namespace ConsoleApp1;

public class Person
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }
    
    // Constructor to initialize Person
    public Person(string name, int age)
    {
        Name = name;
        Age = age;

    }

    public void Introduce()
    {
        Console.WriteLine($"Hi, My name is {Name}");
        Console.WriteLine($"I am {Age} years old");
    }

    public bool Adult()
    {
        return Age >= 18;
    }
}