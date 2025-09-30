using System;
// Base class for all activities
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        // Default values
        _name = "Activity";
        _description = "Base activity class";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting: {_name} - {_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done! You have completed the activity.");
    }

    public void ShowSpinner(int seconds)
    {
        // Simple spinner logic (to be implemented)
    }

    public void ShowCountDown(int seconds)
    {
        // Simple countdown logic (to be implemented)
    }
}
