# Inheritance-Assignments -- Homework Practice

## Project Overview
This project demonstrates the principle of **inheritance** in Object-Oriented Programming (OOP) using a base class (`Assignment`) and two derived classes (`MathAssignment` and `WritingAssignment`). Each class represents a type of school assignment with shared and unique properties.

## Structure
- **AssignmentBase.cs**: Contains the base `Assignment` class with common attributes and GetSummary().
- **MathAssignment.cs**: Inherits from Assignment; adds section and problems; implements GetHomeworkList().
- **WritingAssignment.cs**: Inherits from Assignment; adds title attribute; implements GetWritingInformation().
- **Program.cs**: Main testing file that creates objects, runs methods, and displays sample outputs.

## How to Run
1. Open the project in VSCode.
2. Open a terminal (View > Terminal).
3. Run: dotnet run

4. You should see sample output:

Samuel Bennett - Multiplication
Roberto Rodriguez - Fractions
Section 7.3 Problems 8-19
Mary Waters - European History
The Causes of World War II by Mary Waters
