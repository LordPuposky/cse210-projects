using System;
using System.Collections.Generic;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect by listing items.";
        _duration = 60;
        _count = 0;
        _prompts = new List<string> { "List people you love", "List things that make you happy" };
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        List<string> responses = GetListFromUser();
        _count = responses.Count;
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        // Returns a random prompt from the list
        Random rnd = new Random();
        int idx = rnd.Next(_prompts.Count);
        return _prompts[idx];
    }

    public List<string> GetListFromUser()
    {
        // Gets a list of responses from the user (stub)
        return new List<string>();
    }
}
