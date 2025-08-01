using System;
using System.Collections.Generic;

public class VisualizationActivity : Activity
{
    private static string[] _scenes = {
        "Imagine yourself sitting beside a calm, quiet lake surrounded by trees.",
        "Picture yourself walking slowly on a quiet beach at sunset.",
        "Visualize yourself lying in a field of soft grass under a starlit sky.",
        "Imagine being in a quiet cabin in the mountains, wrapped in a warm blanket."
    };

    private static string[] _prompts = {
        "What sounds can you hear in this place?",
        "What do you feel on your skin (breeze, warmth, etc.)?",
        "What colors or lights do you notice?",
        "What emotions do you feel while being here?",
        "How is your breathing in this moment?",
        "What makes this scene peaceful to you?",
        "What thoughts come to mind in this space?"
    };

    public VisualizationActivity() : base("Visualization Activity",
        "This activity will help you visualize a peaceful scene. It can help clear your mind and reduce stress.") { }

    public override void Run()
    {
        Start();

        Random rand = new Random();
        string scene = _scenes[rand.Next(_scenes.Length)];
        Console.WriteLine("\nVisualize this scene:");
        Console.WriteLine($"--- {scene} ---");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine(_prompts[rand.Next(_prompts.Length)]);
            ShowSpinner(5);
        }

        End();
    }
}
