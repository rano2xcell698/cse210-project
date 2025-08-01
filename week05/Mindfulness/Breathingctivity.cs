using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.") { }

    public override void Run()
    {
        Start();
        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            Countdown(4);
            elapsed += 4;
            if (elapsed >= _duration) break;

            Console.WriteLine("Breathe out...");
            Countdown(6);
            elapsed += 6;
        }

        End();
    }
}
