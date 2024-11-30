using System;

class Program
{
    static void Main(string[] args1)
    {  
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();
        journal.AddEntry();
    }
}