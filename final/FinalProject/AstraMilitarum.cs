public class AstraMilitarum : Imperium
{
    private string _regiment;

    public AstraMilitarum(string name, string regiment, string tagline, string description, string modelName, double modelCost) : base(name, tagline, description, modelName, modelCost)
    {
        _regiment = regiment;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"-Regiment: {_regiment}");
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
