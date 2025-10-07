// Represents a goal that can be completed once

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, string points)
        : base(shortName, description, points)
    {
        _isComplete = false; // Starts incomplete
    }

    // Records the completion of the goal
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
        }
        // Points handling is managed in GoalManager
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        // Format: SimpleGoal|shortName|description|points|isComplete
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}
