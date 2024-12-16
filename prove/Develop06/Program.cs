using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting Eternal Quest Program...");
        
        // Instantiate the GoalManager
        GoalManager goalManager = new GoalManager();
        
        // Start the GoalManager to handle the main program logic
        goalManager.Start();
        
        Console.WriteLine("Thank you for using Eternal Quest. Goodbye!");
    }
}
