using System;
using System.Collections.Generic;
using System.IO;

// Manages all goals and the player's score
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nEternal Quest Menu");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create a New Goal");
            Console.WriteLine("5. Record an Event");
            Console.WriteLine("6. Save Goals to File");
            Console.WriteLine("7. Load Goals from File");
            Console.WriteLine("0. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    SaveGoals();
                    break;
                case "7":
                    LoadGoals();
                    break;
                case "0":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
        
        int level = (_score / 1000) + 1;
        
        Console.WriteLine($"Current Level: {level}");
        
        int nextLevelScore = level * 1000;
        int scoreNeeded = nextLevelScore - _score;
        
        if (scoreNeeded > 0)
        {
            Console.WriteLine($"Points to next level: {scoreNeeded}");
        }
        else
        {
            Console.WriteLine("Congratulations! You are at the maximum current level or just leveled up!");
        }
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Type the number: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter point value: ");
        string points = Console.ReadLine(); // Now points is string

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("Enter target completions: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus value: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        Console.WriteLine("Which goal did you accomplish?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
        }
        Console.Write("Enter goal number: ");
        int num = int.Parse(Console.ReadLine());

        if (num >= 1 && num <= _goals.Count)
        {
            Goal selectedGoal = _goals[num - 1];

            bool wasComplete = selectedGoal.IsComplete();

            selectedGoal.RecordEvent();

            if (!wasComplete)
            {
                int pointsToAdd = 0;
                int.TryParse(selectedGoal.Points, out pointsToAdd);

                if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
                {
                    int bonus = 0;
                    int.TryParse(checklistGoal.GetBonus(), out bonus);
                    pointsToAdd += bonus;
                }

                _score += pointsToAdd;
                Console.WriteLine($"Event recorded! You earned {pointsToAdd} points.");
            }
            else
            {
                Console.WriteLine("Goal already completed or no points earned.");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score); // Save score
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            _score = int.Parse(reader.ReadLine()); // Load score
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string type = parts[0];
                if (type == "SimpleGoal")
                {
                    string name = parts[1];
                    string desc = parts[2];
                    string points = parts[3];
                    bool isComplete = bool.Parse(parts[4]);
                    var goal = new SimpleGoal(name, desc, points);
                    if (isComplete) goal.RecordEvent();
                    _goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    string name = parts[1];
                    string desc = parts[2];
                    string points = parts[3];
                    _goals.Add(new EternalGoal(name, desc, points));
                }
                else if (type == "ChecklistGoal")
                {
                    string name = parts[1];
                    string desc = parts[2];
                    string points = parts[3];
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int completed = int.Parse(parts[6]);
                    var goal = new ChecklistGoal(name, desc, points, target, bonus);
                    for (int i = 0; i < completed; i++) goal.RecordEvent();
                    _goals.Add(goal);
                }
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}
