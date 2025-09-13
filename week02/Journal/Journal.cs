using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Saves all entries to a file in simple CSV format using | as separator.
    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    string line = $"{entry.Date}|{entry.PromptText}|{entry.Mood}|{entry.EntryText}";
                    outputFile.WriteLine(line);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving to file: {e.Message}");
        }
    }

    // Loads entries from a CSV-like file, replacing current entries.
    public void LoadFromFile(string filename)
    {
        try
        {
            string[] lines = File.ReadAllLines(filename);
            _entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length >= 4)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string mood = parts[2];
                    string text = parts[3];
                    Entry entry = new Entry(date, prompt, text, mood);
                    _entries.Add(entry);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading file: {e.Message}");
        }
    }
}
