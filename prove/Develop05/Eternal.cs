public class Eternal : Goal
{
    public Eternal(string name, string description, int pointValue) : base(name, description, pointValue)
    {
        
    }

    public override int RecordEvent()
    {
        return _pointValue;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal:{_name},{_description},{_pointValue}";
    }

}