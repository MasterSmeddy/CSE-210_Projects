public abstract class Faction
{
    protected string _name;
    protected string _tagline;
    protected string _description;
    protected string _modelName;
    protected int _modelCost;

    public Faction(string name, string tagline, string description, string modelName, int modelCost)
    {
        _name = name;
        _tagline = tagline;
        _description = description;
        _modelName = modelName;
        _modelCost = modelCost;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"---- {_name} ----");
        Console.WriteLine($"-Tagline: \"{_tagline}\"");
        Console.WriteLine($"-Description: {_description}");
        Console.WriteLine($"-Most Expensive Model: {_modelName} (${_modelCost}.00)");
        Console.WriteLine();
    }
}
