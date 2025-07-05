using System;

class Program
{
    static void Main(string[] args)
    {
      Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            // Generate random number between 1 and 100
            int magicNumber = random.Next(1, 101);
            int guessCount = 0;
            int userGuess;
            bool hasGuessedCorrectly = false;

            Console.WriteLine("Welcome to Guess My Number!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            // Main game loop
            while (!hasGuessedCorrectly)
            {
                // Get user's guess
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                // Validate input
                if (!int.TryParse(input, out userGuess))
                {
                    Console.WriteLine("Please enter a valid number!");
                    continue;
                }

                guessCount++;

                // Check guess against magic number
                if (userGuess == magicNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {guessCount} guesses!");
                    hasGuessedCorrectly = true;
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher!");
                }
                else
                {
                    Console.WriteLine("Lower!");
                }
            }

            // Ask to play again
            Console.Write("Would you like to play again? (yes/no): ");
            string playAgainResponse = Console.ReadLine().ToLower();
            playAgain = playAgainResponse == "yes" || playAgainResponse == "y";
            Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}