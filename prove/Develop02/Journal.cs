using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public int answer;
    public Entry entry = new Entry();


    public void AddEntry() 
    {
        do 
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");
            Console.Write("What would you like to do? ");
            string x = Console.ReadLine();

            if (int.TryParse(x, out answer))
            {
                switch (answer)
                {
                    case 1:
                        entry.Display(this);
                        break;
                    case 2: 
                        DisplayAll(_entries);
                        break;
                    case 3:
                        LoadFromFile(_entries);
                        break;
                    case 4:
                        SaveToFile(_entries);
                        break;
                    case 5: 
                        Console.WriteLine("Exiting the program.");
                        break;
                    default: 
                        Console.WriteLine("Invalid choice. Please enter a valid input.");
                        break;
                }
            }
                else 
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
        }   while (answer != 5); 
    }

  public void DisplayAll(List<Entry> _entries)
{
    if (_entries.Count == 0)
    {
        Console.WriteLine("No entries to display");
    }
    else
    {
        Console.WriteLine("Journal Entries:");
        Console.WriteLine("--------------------");
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"Response: {entry._entryText}");
            Console.WriteLine("--------------------");
        }
    }
}

   public void SaveToFile(List<Entry> _entries)
{
    if (_entries.Count == 0)
    {
        Console.WriteLine("No entries to save.");
        return;
    }

    Console.WriteLine("What is the filename? ");
    string file = Console.ReadLine();

    if (file == "file.csv")
    {
        Console.WriteLine($"Saving file to: {Path.GetFullPath("file.csv")}");

        
        try
        {
            using (StreamWriter outputFile = new StreamWriter("file.csv", false)) 
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._promptText},{entry._entryText.Replace(",", "\\,")},{entry._date}");
                }
            }
            Console.WriteLine("Entries saved to file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving: {ex.Message}");
        }
    }
    else
    {
        Console.WriteLine("No such filename is found.");
    }
}



public void LoadFromFile(List<Entry> _entries)
{
    Console.WriteLine("What is the filename?");
    string file = Console.ReadLine();

    if (file == "file.csv")
    {
        if (File.Exists(file))
        {
            try
            {
                Console.WriteLine("Reading list from file...");
                string[] lines = File.ReadAllLines(file);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 3) // Validate CSV structure
                    {
                        Entry newEntry = new Entry
                        {
                            _promptText = parts[0],
                            _entryText = parts[1].Replace("\\,", ","), // Unescape commas
                            _date = parts[2]
                        };

                        _entries.Add(newEntry);
                    }
                    else
                    {
                        Console.WriteLine($"Skipping invalid line: {line}");
                    }
                }

                Console.WriteLine("Entries loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading from file: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("File not found. Please check the filename and try again.");
        }
    }
    else
    {
        Console.WriteLine("No such filename is found.");
    }
}
}