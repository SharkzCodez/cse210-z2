using System;

class Program
{
    static void Main(string[] args)
    {
                WelcomeMessage();

        string username = PromptUsername();
        int userNumber = PromptUserNumber();
        int squared = SquareNumber(userNumber);
        Display(username, squared);
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Hello there!");
    }

    static string PromptUsername()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    static void Display(string name, int squared)
    {
        Console.WriteLine($"Hello, {name}. The square of your number is {squared}");
    }
}