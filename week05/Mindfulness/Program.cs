using System;
using System.Collections.Generic;

// Main program class for the Mindfulness application
class Program
{
    static void Main(string[] args)
    {
        bool continueRunning = true;

        while (continueRunning)
        {            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case "4":
                    continueRunning = false;
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1-4.");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
