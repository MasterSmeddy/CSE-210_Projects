public class ChaosMarines : Chaos
{
    private string _primarch;

    public ChaosMarines(string name, string god, string primarch, string tagline, string description, string modelName, double modelCost) : base(name, god, tagline, description, modelName, modelCost)
    {
        _primarch = primarch;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"-Aligned with: {_god}");
        Console.WriteLine($"-Primarch: {_primarch}");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
    }

    public override bool GetsAlongWith(Faction faction)
    {
        if (faction is Chaos)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
