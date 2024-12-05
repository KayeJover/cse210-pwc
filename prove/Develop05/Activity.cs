using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public abstract class Activity
{
    protected string Name { get; }
    protected string Description { get; }
    protected int _duration;

    private static Dictionary<string, int> activityLog = new Dictionary<string, int>();

    protected Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {Name}...\n{Description}");
        Console.WriteLine($"You will do this for {_duration} seconds.\n");
        Console.WriteLine("Press Enter to begin...");
        Console.ReadLine();
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood job! You have completed the activity.");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    protected void LogActivity()
    {
        if (!activityLog.ContainsKey(Name))
            activityLog[Name] = 0;

        activityLog[Name]++;
    }

    public static void DisplayActivityLog()
    {
        if (activityLog.Count == 0)
        {
            Console.WriteLine("\nActivity Log is empty.");
        }
        else
        {
            Console.WriteLine("\nActivity Log:");
            foreach (var entry in activityLog)
            {
                Console.WriteLine($"- {entry.Key}: {entry.Value} time(s)");
            }
        }
    }

    public static void SaveLog()
    {
        try
        {
            File.WriteAllText("activityLog.txt", string.Join("\n", activityLog.Select(kvp => $"{kvp.Key}:{kvp.Value}")));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving log: {ex.Message}");
        }
    }

    public static void LoadLog()
    {
        if (File.Exists("activityLog.txt"))
        {
            try
            {
                foreach (var line in File.ReadAllLines("activityLog.txt"))
                {
                    var parts = line.Split(':');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int count))
                    {
                        activityLog[parts[0]] = count;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading log: {ex.Message}");
            }
        }
    }

    public abstract void Run();
}
