// Derived class for writing assignments: extends the base Assignment class
public class WritingAssignment : Assignment
{
    // Specific field for writing assignments
    private string _title;

    // Constructor (requires all specific values)
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic) // Call the base class constructor
    {
        _title = title;
    }

    // Method to return writing information (title and student name)
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}
