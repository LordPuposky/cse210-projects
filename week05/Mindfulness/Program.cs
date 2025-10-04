using System;
using System.Collections.Generic;

// Main program class for the Mindfulness application
class Program
{
    static void Main(string[] args)
    {
        // CREATIVITY AND EXCEEDING CORE REQUIREMENTS:
        // 1. Early Completion Feature: Users can type 'done' in the Listing Activity
        //    to finish before the timer ends, providing flexibility and control.
        //    This prevents users from having to wait if they've completed their list early.
        //
        // 2. Enhanced User Feedback: Added confirmation prompts in ListingActivity
        //    after each entry, asking users if they want to continue or finish.
        //    This improves user experience by making the activity more interactive.
        //
        // 3. Input Validation: Implemented robust error handling for duration input
        //    with a default fallback value, ensuring the program never crashes
        //    from invalid user input.
        //
        // 4. User-Friendly Menu Loop: The menu automatically clears and re-displays
        //    after each activity completes, providing a seamless experience without
        //    requiring the user to restart the program.

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