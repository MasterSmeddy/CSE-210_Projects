public class SpaceMarines : Imperium
{
    private string _primarch;

    public SpaceMarines(string name, string primarch, string tagline, string description, string modelName, double modelCost) : base(name, tagline, description, modelName, modelCost)
    {
        _primarch = primarch;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"-Primarch: {_primarch}");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
    }

    public override bool GetsAlongWith(Faction faction)
    {
        if (faction is Imperium)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
