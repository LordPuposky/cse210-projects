// Entry point to create and use the assignment classes in practice
using System;
class Program
{
    static void Main(string[] args)
    {
        // Create example of MathAssignment
        MathAssignment math = new MathAssignment("Juan Perez", "Fractions", "7.3", "8-19");
        Console.WriteLine("-- Math Assignment --");
        Console.WriteLine(math.GetSummary());         // Output: Juan Perez - Fractions
        Console.WriteLine(math.GetHomeworkList());    // Output: Section 7.3 Problems 8-19

        // Create example of WritingAssignment
        WritingAssignment writing = new WritingAssignment("Maria Lopez", "European History", "Causes of World War II");
        Console.WriteLine("-- Writing Assignment --");
        Console.WriteLine(writing.GetSummary());              // Output: Maria Lopez - European History
        Console.WriteLine(writing.GetWritingInformation());   // Output: Causes of World War II by Maria Lopez
    }
}

