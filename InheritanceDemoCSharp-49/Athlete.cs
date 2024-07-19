namespace InheritanceDemoCSharp_49;

public class Athlete : Person
{
    public string Sport { get; set; }

    public void PlaySport()
    {
        Console.WriteLine($"I play {Sport}!");
    }
}