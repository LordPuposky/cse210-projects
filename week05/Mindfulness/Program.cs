using System;
class Program
{
    static void Main(string[] args)
    {
        // Simple menu logic
        Console.WriteLine("Mindfulness Program");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflecting Activity");
        Console.WriteLine("Select an activity:");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                break;
            case "2":
                ListingActivity listing = new ListingActivity();
                listing.Run();
                break;
            case "3":
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                break;
            default:
                Console.WriteLine("Goodbye!");
                break;
        }
    }
}
