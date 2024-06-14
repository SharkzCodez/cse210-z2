using System;

class Program
{
    static void Main(string[] args)
    {
        
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
    }
}