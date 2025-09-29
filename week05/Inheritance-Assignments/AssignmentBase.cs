// Base class for assignments
public class Assignment
{
    // Private member variables for student name and topic
    protected string _studentName;
    protected string _topic;

    // Constructor: receives student name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to return summary (student name and topic)
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
