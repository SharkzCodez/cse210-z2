using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstn = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastn = Console.ReadLine();

        Console.WriteLine($"Your name is {lastn}, {firstn} {lastn}.");



        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string grade = "";

        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Try again.");
        }



        Console.WriteLine("What is the magic number? ");
        int magicNum = int.Parse(Console.ReadLine());
        
        int guess = -1;
        while (guess != magicNum)
        {
            Console.Write("What do you guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNum > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }



        List<int> numbers = new List<int>();
        int addNum = -1;
        while (addNum != 0)
        {
            Console.Write("Enter numbers to add to the list. Enter 0 to quit. ");
            string userNum = Console.ReadLine();
            addNum = int.Parse(userNum);

            if (addNum != 0)
            {
                numbers.Add(addNum);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = numbers[0];
        foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
        Console.WriteLine($"The max is {max}");

        

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