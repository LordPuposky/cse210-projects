using System;

public class Entry
{
    public string Date { get; private set; }
    public string PromptText { get; private set; }
    public string EntryText { get; private set; }
    public string Mood { get; private set; } // New mood property

    public Entry(string date, string promptText, string entryText, string mood = "")
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
        Mood = mood;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Mood: {Mood}");
        Console.WriteLine($"Entry: {EntryText}\n");
    }
}
