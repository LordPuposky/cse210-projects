using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by guiding you through breathing.";
        _duration = 60; // default duration in seconds
    }

    public void Run()
    {
        DisplayStartingMessage();
        // Breathing steps logic here
        DisplayEndingMessage();
    }
}
