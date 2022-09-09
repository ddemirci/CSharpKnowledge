namespace DotNetKnowledge.Deconstruction;

// Deconstruction functionality can be added to the classes.
public class Vehicle
{
    public string Make { get; init; }
    public string Model { get; init; }
    public int Year { get; init; }

    /// <summary>
    /// Method name has to be "Deconstruct"
    /// </summary>
    /// <param name="make"></param>
    /// <param name="model"></param>
    /// <param name="year"></param>
    public void Deconstruct(out string make, out string model, out int year)
    {
        make = Make;
        model = Model;
        year = Year;
    }
}

//Records have deconstruction functionality by default
public record Company(string Name, int Founded); 