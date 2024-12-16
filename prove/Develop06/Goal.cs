public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    public abstract string GetStringRepresentation();

    public virtual bool IsComplete()
    {
        return false;
    }
}
