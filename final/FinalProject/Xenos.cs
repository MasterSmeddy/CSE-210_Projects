public class Xenos : Faction
{
    public Xenos(string name, string tagline, string description, string modelName, double modelCost) : base(name, tagline, description, modelName, modelCost)
    {
        
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
    }

    public override bool GetsAlongWith(Faction faction)
    {
        return false;
    }
}