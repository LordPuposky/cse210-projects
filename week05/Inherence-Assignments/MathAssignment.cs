// Derived class for math assignments: extends the base Assignment class
public class MathAssignment : Assignment
{
    // Specific fields for math assignments
    private string _textbookSection;
    private string _problems;

    // Constructor (requires all specific values)
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic) // Call the base class constructor
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method to display the math homework list (section and problems)
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
