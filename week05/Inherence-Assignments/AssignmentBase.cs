// Base class for assignments: common attributes and summary method
public class Assignment
{
    // Fields (protected: can be accessed by classes that inherit from Assignment)
    protected string _studentName;
    protected string _topic;

    // Constructor (requires student name and assignment topic)
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to get a summary of the assignment (name and topic)
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
