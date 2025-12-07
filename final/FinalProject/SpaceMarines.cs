public class SpaceMarines : Imperium
{
    private string _primarch;

    public SpaceMarines(string name, string primarch, string tagline, string description, string modelName, int modelCost) : base(name, tagline, description, modelName, modelCost)
    {
        _primarch = primarch;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"---- { _name } ----");
        Console.WriteLine($"Primarch: {_primarch}");
        Console.WriteLine($"Tagline: \"{_tagline}\"");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Most Expensive Model: {_modelName} (${_modelCost}.00)");
        Console.WriteLine();
    }
}
