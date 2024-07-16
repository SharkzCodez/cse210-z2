using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> memorizer = new List<string>
        {
            "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.",
            "2 Yea, behold, I will tell you in your mind and in your heart, by the Holy Ghost, which shall come upon you and which shall dwell in your heart. 3 Now, behold, this is the spirit of revelation; behold, this is the spirit by which Moses brought the children of Israel through the Red Sea on dry ground."
        };
        

        string userChoice;
        Console.WriteLine("Which scripture would you like to work on?");
        Console.WriteLine("1. James 1:5");
        Console.WriteLine("2. D&C 8:2-3");

        userChoice = Console.ReadLine();

        while (userChoice != "quit")
        {
            if (userChoice == "1")
            {
                Reference reference = new Reference("James", 1, 5);
                Scripture james = new Scripture(reference, memorizer[0]);
                while (!james.IsCompletelyHidden())
                {
                    james.HideRandomWords();
                    james.GetDisplayText();
                    Console.WriteLine(james);
                    Console.ReadLine();

                }
            }
            else if (userChoice == "2")
            {
                Reference reference = new Reference("D&C", 8, 2, 3);
                Scripture dc = new Scripture(reference, memorizer[1]);
                while (!dc.IsCompletelyHidden())
                {
                    dc.HideRandomWords();
                    dc.GetDisplayText();
                    Console.ReadLine();
                }
            }

        }
        
        userChoice = "";


    }
}