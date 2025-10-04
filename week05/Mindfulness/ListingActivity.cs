// ListingActivity.cs
using System;
using System.Collections.Generic;

// Listing activity to help users reflect by listing positive things
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> responses = new List<string>();
        _count = 0;

        Console.WriteLine("Start listing! Press Enter after each item.");
        Console.WriteLine("If you are done early, type 'done' and press Enter to finish.");
        Console.WriteLine();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            // User can stop early
            if (input != null && input.ToLower() == "done")
            {
                break;
            }

            if (DateTime.Now >= endTime) break;

            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
                _count++;
                Console.WriteLine("Are you thinking of someone else or are you done? If finished, type 'done' and press Enter.");
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        return _prompts[rnd.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        // Not used in this implementation
        return new List<string>();
    }
}
