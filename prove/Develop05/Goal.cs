public class Goal
{
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected bool _goalComplete;

    public Goal(string name, string description, int pointValue, bool goalComplete)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
        _goalComplete = goalComplete;
    }

    public Goal(string name, string description, int pointValue)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
    }

    public virtual void GetGoal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _pointValue = int.Parse(Console.ReadLine());
    }

    public virtual void DisplayGoal()
    {
        string checkbox;

        if (_goalComplete == true)
        {
            checkbox = "[X]";
        }
        else
        {
            checkbox = "[ ]";
        }

        Console.WriteLine($"{checkbox} {_name} ({_description})");
    }

    public virtual string GetStringRepresentation()
    {
        return $"Simple:{_name},{_description},{_pointValue},{_goalComplete}";
    }

    public virtual int RecordEvent()
    {
        _goalComplete = true;
        return _pointValue;
    }

}