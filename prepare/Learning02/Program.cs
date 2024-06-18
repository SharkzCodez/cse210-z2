using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Web Developer";
        job1._company = "Microsoft";
        job1._startYear = 2016;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Project Manager";
        job2._company = "Frito Lay";
        job2._startYear = 2021;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Jade Harley";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}