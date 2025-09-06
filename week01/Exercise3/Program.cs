using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while (playAgain.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); // Number among 1 y 100
            int guessCount = 0;
            int guess = -1;

            Console.WriteLine("Guess My Number Game!");
            // Console.WriteLine($"[DEBUG] The magic number is: {magicNumber}");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please enter a valid integer.");
                    continue;
                }

                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}
