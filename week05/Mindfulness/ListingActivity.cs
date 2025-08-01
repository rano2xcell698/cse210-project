using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private static string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "When have you felt peace recently?",
        "Who are some of your heroes?"
    };

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on positive things by listing items in a chosen area.") { }

    public override void Run()
    {
        Start();
        Random rand = new Random();

        Console.WriteLine();
        Console.WriteLine("Prompt:");
        Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Length)]} ---");
        Console.WriteLine("You may begin in:");
        Countdown(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input);
        }

        Console.WriteLine($"You listed {items.Count} items!");
        End();
    }
}
