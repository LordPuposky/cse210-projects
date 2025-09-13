/*
 * Journal Program - CS210 Week 02 Project
 * Author: Yesid Augusto Romero Ruiz
 * 
 * This program meets all core requirements for the assignment:
 * - Abstracted Journal and Entry classes with clear responsibilities.
 * - Random prompt generation from a predefined list.
 * - Writing, displaying, saving (CSV format), and loading entries from a file.
 *
 * Improvements and creativity beyond core requirements:
 * - Added a "Mood" field in each journal entry to capture the user's emotional state.
 * - Implemented saving and loading in a CSV-like format using a pipe '|' separator,
 *   simplifying parsing and avoiding common issues with commas inside text.
 * - Included basic error handling in file operations to provide user-friendly
 *   messages if saving or loading fails.
 * - Organized code into separate files with consistent naming and formatting,
 *   enhancing maintainability and readability.
 *
 * These enhancements improve the usability and functionality of the journal,
 * making it richer and more robust, while demonstrating solid principles
 * of abstraction and file management.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        Console.WriteLine("Welcome to Your Personal Journal!");

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string date = DateTime.Now.ToShortDateString();
                    Console.WriteLine("How are you feeling today? (optional)");
                    string mood = Console.ReadLine();
                    Console.Write("Entry: ");
                    string entryText = Console.ReadLine();
                    Entry entry = new Entry(date, prompt, entryText, mood);
                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save (e.g., journal.txt): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved.");
                    break;

                case "4":
                    Console.Write("Enter filename to load (e.g., journal.txt): ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded.");
                    break;

                case "5":
                    exit = true;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
