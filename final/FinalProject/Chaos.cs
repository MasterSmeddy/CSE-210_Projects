public abstract class Chaos : Faction
{
    protected string _god;
    public Chaos(string name, string god, string tagline, string description, string modelName, int modelCost) : base(name, tagline, description, modelName, modelCost)
    {
        _god = god;
    }
}
