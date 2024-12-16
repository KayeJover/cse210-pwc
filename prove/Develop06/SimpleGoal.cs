public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        _isComplete = false;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Name},{Description},{Points},{_isComplete}";
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public void MarkComplete()
    {
        _isComplete = true;
    }
}
