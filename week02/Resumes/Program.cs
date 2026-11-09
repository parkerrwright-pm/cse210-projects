using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Company A";
        job1._jobTitle = "Software Developer";
        job1._startDate = "January 2020";
        job1._endDate = "December 2021";

        Job job2 = new Job();
        job2._company = "Company B";
        job2._jobTitle = "Project Manager";
        job2._startDate = "February 2018";
        job2._endDate = "December 2019";

        Resume myResume = new Resume();

        myResume._name = "John Doe";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}