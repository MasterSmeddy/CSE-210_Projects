public class Checklist : Goal
{
    private int _goalLimit;
    private int _progress;
    private int _bonusPointsValue;
    public Checklist(string name, string description, int pointValue, int bonusPointsValue, int goalLimit, int progress, bool goalComplete) : base(name, description, pointValue, goalComplete)
    {
        _goalLimit = goalLimit;
        _bonusPointsValue = bonusPointsValue;
        _progress = progress;
    }

    public override void GetGoal()
    {
        base.GetGoal();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _goalLimit = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPointsValue = int.Parse(Console.ReadLine());
    }

    public override int RecordEvent()
    {
        _progress++;

        if (_progress >= _goalLimit)
        {
            _goalComplete = true;
            return _pointValue + _bonusPointsValue;
        }

        return _pointValue;
    }

    public override void DisplayGoal()
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

        Console.WriteLine($"{checkbox} {_name} ({_description}) -- Currently completed: {_progress}/{_goalLimit}");
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist:{_name},{_description},{_pointValue},{_progress},{_goalLimit},{_bonusPointsValue},{_goalComplete}";
    }

}