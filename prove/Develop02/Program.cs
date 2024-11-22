using System;

class Program
{
    static void Main(string[] args1)
    {  
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();
        journal.AddEntry();
    }

    // Used csv file (named as "file.csv") as a storage for the journal entries
    // See lines starting from line 73 on Journal.cs file
}