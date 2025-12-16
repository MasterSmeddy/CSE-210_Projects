public abstract class Chaos : Faction
{
    protected string _god;

    public Chaos(string name, string god, string tagline, string description, string modelName, double modelCost)
        : base(name, tagline, description, modelName, modelCost)
    {
        _god = god;
    }

    // public Chaos()
    //     : base(
    //         "Forces of Chaos",
    //         "For the Dark Gods!",
    //         "Chaos represents the corrupted and twisted forces of universe within a parallel dimension, known as the the Warp.\nThese armies follow various dark gods and spread destruction, mutation, and madness across the galaxy.",
    //         "Knight Ruinator",
    //         200
    //     )
    // {
    //     _god = "Various Chaos Gods";
    // }

    // public override void DisplayInfo()
    // {
    //     Console.WriteLine($"---- {_name} ----");
    //     Console.WriteLine($"-God: {_god}");
    //     Console.WriteLine($"-Tagline: \"{_tagline}\"");
    //     Console.WriteLine($"-Description: {_description}");
    //     Console.WriteLine($"-Most Expensive Model: {_modelName} (${_modelCost}.00)");
    //     Console.WriteLine();
    // }
}
