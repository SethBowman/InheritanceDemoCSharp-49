namespace InheritanceDemoCSharp_49;

public class Person
{
    //properties
    public string Name { get; set; }
    public int Age { get; set; }
    
    //methods
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name}!");
    }
}