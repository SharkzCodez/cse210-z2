using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("754 Cantelope Drive", "Tampa", "Florida", "USA");
        Address address2 = new Address("234 Coolsville Street", "Memphis", "Tennisee", "USA");

        Event lecture = new Lecture("Talk the Talk", "A informative guide on how to exude confidence in the workplace", "3/30/24", "11:30 AM", address2, "Gus Manfred", 250);
        Event reception = new Reception("Ronald's Eagle Scout Celebration", "A Court of Honor and reception in honor of Ronald making Eagle Scout", "6/12/24", "2:00 PM", address2, "ronaldcoolsville@hotmail.com");
        Event outdoorGathering = new Outdoorgathering("Music Fest", "An outdoor festival where up-and-coming musicians can show off their skills", "8/24/24", "10:00 PM", address1, "Sunny and breezy");

        Console.WriteLine(lecture.Details());
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine(lecture.ShortDescription());
        Console.WriteLine();
        Console.WriteLine(reception.Details());
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine(reception.ShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.Details());
        Console.WriteLine(outdoorGathering.FullDetails());
        Console.WriteLine(outdoorGathering.ShortDescription());

    }
}