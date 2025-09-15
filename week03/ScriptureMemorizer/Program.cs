/*
Author: Yesid Augusto Romero Ruiz
Course: CSE 210 - Programming with Classes
Project: Scripture Memorizer

This program helps users memorize scriptures by displaying a scripture
(reference and text) and progressively hiding words as the user practices.

Improvement included:
- When hiding words, the first letter of each hidden word is left visible
to aid memorization.

User interacts by pressing Enter to hide more words or typing 'quit' to exit.
*/
using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Reference object (example with a single verse)
            Reference reference = new Reference("John", 3, 16);

            // Scripture text corresponding to the reference
            string scriptureText = "For God so loved the world that he gave his one and only Son, " +
                                "that whoever believes in him shall not perish but have eternal life.";

            // Create Scripture object with the reference and text
            Scripture scripture = new Scripture(reference, scriptureText);

            while (true)
            {
                Console.Clear();

                // Display the current state of the scripture (with hidden words)
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();

                // Check if all words are hidden, end the program if true
                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("All words have been hidden. Program finished.");
                    break;
                }

                // Prompt the user to press Enter or type quit
                Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
                string userInput = Console.ReadLine();

                // Exit if user types quit
                if (userInput.ToLower() == "quit")
                {
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;
                }

                // If user presses Enter, hide some words

                if (userInput == "")
                {
                    // Hide 3 words at a time (adjustable)
                    scripture.HideRandomWords(3);
                }
            }
        }
    }
}
