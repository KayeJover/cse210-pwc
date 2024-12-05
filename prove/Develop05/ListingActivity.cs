using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "When have you felt the Holy Ghost this month?",
        "Who have you helped this week?",
        "What are you grateful for today?"
    };

    private List<string> usedPrompts = new List<string>();

    public ListingActivity() : base("Listing Activity", "This activity will help you list as many responses as you can to a given prompt.")
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
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nYou may begin in:");
        ShowCountdown(3);

       // Collect responses for the duration of the activity
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Console.WriteLine(); 
        while (DateTime.Now < endTime)
        {
            Console.Write("> "); 
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }

        Console.WriteLine($"\nYou listed {responses.Count} responses.");
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
