using System;

class Program
{
    static void Main(string[] args)
    {
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
    }
}