// Represents a goal that can be recorded any number of times
public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points)
        : base(shortName, description, points)
    {
        // No additional initialization needed for eternal goals
    }

    // Records the event but does not mark as complete since eternal goals never end
    public override void RecordEvent()
    {
        // Eternal goals can always be recorded, no completion state to change
        // Points handling would be done in GoalManager when this method is called
    }

    // Eternal goals are never considered complete
    public override bool IsComplete()
    {
        return false; // Eternal goals never end
    }

    // Provides string representation for saving to file
    public override string GetStringRepresentation()
    {
        // Format: EternalGoal|shortName|description|points
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}
