using System;

class Program
{
    static void Main(string[] args)
    {
        // Load existing activity log
        Activity.LoadLog();

        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Activity Log");
            Console.WriteLine("5. Save Activity Log");
            Console.WriteLine("6. Exit");

            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();

            Activity activity = null;

        
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectingActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    Activity.DisplayActivityLog();
                    continue; 
                case "5":
                    Activity.SaveLog();
                    Console.WriteLine("Activity log saved successfully.");
                    continue;
                case "6":
                    Console.WriteLine("Goodbye!");
                    return; 
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    continue; 
            }

            if (activity != null)
            {
                Console.Write("Enter the duration (in seconds): ");
                if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
                {
                    activity.SetDuration(duration);
                    activity.Run();
                }
                else
                {
                    Console.WriteLine("Invalid duration. Please enter a positive number.");
                }
            }
        }
    }
}
// Adding another kind of activity.
//Keeping a log of how many times activities were performed.
//No random prompts/questions are selected until they have all been used at least once in that session.
//Saving and loading a log file.
//Adding more meaningful animations for the breathing (such as text that grows out quickly at first and then slows as they near the end of the breath).