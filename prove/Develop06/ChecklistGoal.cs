public class ChecklistGoal : Goal
{
    public int Target { get; set; }
    public int Bonus { get; set; }
    public int AmountCompleted { get; set; }

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
    {
        Name = name;
        Description = description;
        Points = points;
        Target = target;
        Bonus = bonus;
        AmountCompleted = 0;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name},{Description},{Points},{Target},{Bonus},{AmountCompleted}";
    }
}
