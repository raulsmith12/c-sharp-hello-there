using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int guess = 0;
        int attempts = 0;
        bool isRunning = true;

        Console.WriteLine("=== Number Guessing Game ===");
        Console.WriteLine("I'm thinking of a number between 1 and 100...");
        Console.WriteLine("Can you guess it?\n");

        while (isRunning)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Please enter a valid number!");
                continue;
            }

            attempts++;

            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Out of range! Guess between 1 and 100.");
                continue;
            }

            if (guess < secretNumber)
                Console.WriteLine("Too low!");
            else if (guess > secretNumber)
                Console.WriteLine("Too high!");
            else
            {
                Console.WriteLine($"\n🎉 You guessed it in {attempts} attempts!");
                isRunning = false;
            }
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
