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
            Console.WriteLine("Journal entries: ");
            foreach (Entry entry in _entries)
            {
                Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
                Console.WriteLine($"{entry._entryText}");
            }
        }
    }

    

    public void SaveToFile(List<Entry> _entries) 
    {
        Console.WriteLine("What is the filename? ");
        string file = Console.ReadLine();

        if (file == "file.csv")
        {
            Console.WriteLine("Saving to file...");

            string filename = "file.csv";

            using (StreamWriter outputFile = new StreamWriter (filename, append: true))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._promptText},{entry._entryText},{entry._date}");
                }

            }

            Console.WriteLine("Entries saved to file successfully.");
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
            Console.WriteLine("Reading list from file...");

            string filename = "file.csv";
            string [] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                Entry newEntry = new Entry();
                newEntry._promptText = parts[0];
                newEntry._entryText = parts[1];
                newEntry._date = parts[2];

                _entries.Add(newEntry);
            }
        }
        else 
        {
            Console.WriteLine("No such filename is found.");
        }
    }   
}  