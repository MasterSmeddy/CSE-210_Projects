public class ChaosMarines : Chaos
{
    private string _primarch;

    public ChaosMarines(string name, string god, string primarch, string tagline, string description, string modelName, int modelCost) : base(name, god, tagline, description, modelName, modelCost)
    {
        _primarch = primarch;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"---- {_name} ----");
        Console.WriteLine($"-God: {_god}");
        Console.WriteLine($"-Primarch: {_primarch}");
        Console.WriteLine($"-Tagline: \"{_tagline}\"");
        Console.WriteLine($"-Description: {_description}");
        Console.WriteLine($"-Most Expensive Model: {_modelName} (${_modelCost}.00)");
        Console.WriteLine();
    }
}
