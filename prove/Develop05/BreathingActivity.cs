using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    private void EnhancedBreathingAnimation(string action, int duration)
    {
        for (int i = 1; i <= duration; i++)
        {
            Console.Clear();
            int size = i * 2 + 1; // Dynamic growth
            Console.WriteLine(new string(' ', (30 - size) / 2) + new string('*', size));
            Console.WriteLine($"\n{action}... ({duration - i} seconds left)");
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine($"{action} complete!");
        Thread.Sleep(1000);
    }

    public override void Run()
    {
        DisplayStartingMessage();
        int cycles = _duration / 10;

        for (int i = 0; i < cycles; i++)
        {
            EnhancedBreathingAnimation("Breathe in", 4);
            EnhancedBreathingAnimation("Breathe out", 6);
        }

        DisplayEndingMessage();
        LogActivity();
    }
}
