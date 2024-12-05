using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you did something really difficult.",
        "Reflect on a moment when you helped someone in need.",
        "Consider a time when you overcame a fear."
    };

    private List<string> usedPrompts = new List<string>();

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    private string GetRandomPrompt()
    {
        if (usedPrompts.Count == _prompts.Count)
            usedPrompts.Clear();

        Random random = new Random();
        string prompt;
        do
        {
            prompt = _prompts[random.Next(_prompts.Count)];
        } while (usedPrompts.Contains(prompt));

        usedPrompts.Add(prompt);
        return prompt;
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in:");
        ShowCountdown(3);

        Console.WriteLine("\n> How did you feel when it was complete?");
        Thread.Sleep(_duration * 1000);

        DisplayEndingMessage();
        LogActivity();
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}... ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
