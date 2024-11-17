using System;

class Program
{
    static void Main(string[] args)
    {  
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();
        journal.AddEntry();
    }

    // improved the process of saving and loading the journal entries
    // utilized a csv file named "file.csv" that could be opened in Excel
}