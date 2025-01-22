using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "IT Team Lead";
        job2._startYear = 2020;
        job2._endYear = 2025;

        Resume resume1 = new Resume();
        resume1._name = "Lincoln Huls";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}