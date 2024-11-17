using System;
using System.IO;
using System.Collections.Generic;



public class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _entryText { get; set; }
    public void Display(Journal journal)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string _randomPrompt = promptGenerator.GetRandomPrompt(promptGenerator._prompts);

        Entry newEntry = new Entry();

        Console.WriteLine(_randomPrompt);
            newEntry._promptText = _randomPrompt;
        Console.Write("Enter your input here: ");
            newEntry._entryText = Console.ReadLine();
            newEntry._date = DateTime.Now.ToString();

            journal._entries.Add(newEntry);

        Console.WriteLine($"Number of entries: {journal._entries.Count}");
    }
}