// Main method: creates assignments, gets and displays summaries
using System;

class Program
{
    static void Main(string[] args)
    {
        // Test base assignment
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary()); // Output: Samuel Bennett - Multiplication

        // Test inherited classes
        MathAssignment math = new MathAssignment("Juan Perez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());         // Output: Juan Perez - Fractions
        Console.WriteLine(math.GetHomeworkList());    // Output: Section 7.3 Problems 8-19

        WritingAssignment writing = new WritingAssignment("Maria Lopez", "European History", "Causes of World War II");
        Console.WriteLine(writing.GetSummary());              // Output: Maria Lopez - European History
        Console.WriteLine(writing.GetWritingInformation());   // Output: Causes of World War II by Maria Lopez
    }
}
