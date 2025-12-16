public abstract class Faction
{
    protected string _name;
    protected string _tagline;
    protected string _description;
    protected string _modelName;
    protected double _modelCost;

    public Faction(string name, string tagline, string description, string modelName, double modelCost)
    {
        _name = name;
        _tagline = tagline;
        _description = description;
        _modelName = modelName;
        _modelCost = modelCost;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"------------ {_name} ------------");
        Console.WriteLine($"-Warcry: \"{_tagline}\"");
        Console.WriteLine($"-Description: {_description}");
        Console.WriteLine($"-Most Expensive Model: {_modelName} (${_modelCost:F2})");
    }

    public abstract bool GetsAlongWith(Faction faction);
}
