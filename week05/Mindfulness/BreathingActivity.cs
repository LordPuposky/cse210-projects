using System;

// Breathing activity to help users relax through guided breathing
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            
            if (DateTime.Now >= endTime) break;
            
            Console.Write("Now breathe out...");
            ShowCountDown(6);
        }

        DisplayEndingMessage();
    }
}
