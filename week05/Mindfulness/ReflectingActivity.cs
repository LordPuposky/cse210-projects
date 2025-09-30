using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity helps you reflect on meaningful moments.";
        _duration = 50;
        _prompts = new List<string> { "Think of a time you helped someone." };
        _questions = new List<string> { "Why was this experience meaningful?", "How did it make you feel?" };
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int idx = rnd.Next(_prompts.Count);
        return _prompts[idx];
    }

    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int idx = rnd.Next(_questions.Count);
        return _questions[idx];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        foreach (var question in _questions)
        {
            Console.WriteLine(question);
        }
    }
}
