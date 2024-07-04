

using System;


class Program
{
    static void Main(string[] args)
    {
        string userSelect;
        PromptGenerator generator = new PromptGenerator();
        Journal _journalEntries = new Journal();
        Console.WriteLine("Welcome to your journal!");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save to file");
        Console.WriteLine("4. View file");
        Console.WriteLine("5. Quit");

        userSelect = Console.ReadLine();

        while (userSelect != "5")
        {
            if (userSelect == "1")
            {
                Entry entry = new Entry
                {
                    _date = DateTime.Now.ToString(),
                    _promptText = generator.GetRandomPrompt(),
                    _entryText = Console.ReadLine(),
                };
                _journalEntries.AddEntry(entry);
            }

            else if (userSelect == "2")
            {
                _journalEntries.DisplayAll();
            }

            else if (userSelect == "3")
            {
                _journalEntries.SaveToFile("journal.txt"); 
            }

            else if (userSelect == "4")
            {
                _journalEntries.LoadFromFile("journal.txt");
            }

            else if (userSelect == "5")
            {Environment.Exit(0);}

            userSelect = Console.ReadLine();
        }

        

    }
}