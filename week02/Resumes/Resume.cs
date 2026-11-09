using System;
using System.Collections.Generic;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
            Console.WriteLine($"Company: {job._company}");
            Console.WriteLine($"Job Title: {job._jobTitle}");
            Console.WriteLine($"Start Date: {job._startDate}");
            Console.WriteLine($"End Date: {job._endDate}");
            Console.WriteLine();
        }
    }
}