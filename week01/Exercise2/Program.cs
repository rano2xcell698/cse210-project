using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentge:  ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Print the letter grade
        Console.WriteLine($"Your grade is: {letter}");

        // Check if the student passed
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working at it! You'll do better next time.");
        }
    }
}
    
