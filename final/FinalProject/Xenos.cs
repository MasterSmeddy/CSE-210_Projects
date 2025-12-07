public class Xenos : Faction
{
    public Xenos(string name, string tagline, string description, string modelName, int modelCost) : base(name, tagline, description, modelName, modelCost)
    {
        
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"---- {_name} ----");
        Console.WriteLine($"-Tagline: \"{_tagline}\"");
        Console.WriteLine($"-Description: {_description}");
        Console.WriteLine($"-Most Expensive Model: {_modelName} (${_modelCost}.00)");
        Console.WriteLine();
    }
}