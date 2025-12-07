public class AstraMilitarum : Imperium
{
    private string _regiment;

    public AstraMilitarum(string name, string regiment, string tagline, string description, string modelName, int modelCost) : base(name, tagline, description, modelName, modelCost)
    {
        _regiment = regiment;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"---- { _name } ----");
        Console.WriteLine($"Regiment: {_regiment}");
        Console.WriteLine($"Tagline: \"{_tagline}\"");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Most Expensive Model: {_modelName} (${_modelCost}.00)");
        Console.WriteLine();
    }
}
