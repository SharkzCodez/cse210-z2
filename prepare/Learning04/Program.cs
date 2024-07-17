using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("John Eggbert", "Algebra 1");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Tsukasa Tenma", "Calculus", "5.8", "7-11");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Sans Undertale", "American History", "The Industrial Revolution");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}