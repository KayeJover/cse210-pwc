using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorization Program!\n");

        ScriptureLibrary library = new ScriptureLibrary();
        library.AddScriptures();

        while (true)
        {
            library.DisplayScriptureList();
            Console.Write("\nPlease choose a scripture verse: "); // Adjusted this line

            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 5)
            {
                Scripture selectedScripture = library.GetScriptureByIndex(choice - 1);
                Console.WriteLine("\n" + selectedScripture.Text);

                while (true)
                {
                    Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
                    string action = Console.ReadLine();

                    if (action.ToLower() == "quit")
                    {
                        Console.WriteLine("Exiting the program.");
                        return;
                    }
                    else
                    {
                        selectedScripture.HideWords();
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please select a number between 1 and 5.");
            }
        }
    }
}
