// Abstract base class for all goal types
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    // Properties for safe access to the protected fields
    public string ShortName => _shortName;
    public string Description => _description;
    public string Points => _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // Abstract methods to be implemented by each type of goal
    public abstract void RecordEvent();
    public abstract bool IsComplete();

    // Virtual method to get details string for listings
    public virtual string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";
    }

    // Abstract method for string representation (serialization)
    public abstract string GetStringRepresentation();
}
