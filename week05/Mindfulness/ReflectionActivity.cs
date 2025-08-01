using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private static string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself?",
        "How can you keep this in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity",
        "This activity will help you reflect on times you've shown strength and resilience.") { }

    public override void Run()
    {
        Start();
        Random rand = new Random();

        Console.WriteLine();
        Console.WriteLine("Prompt:");
        Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Length)]} ---");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine(_questions[rand.Next(_questions.Length)]);
            ShowSpinner(5);
        }

        End();
    }
}
