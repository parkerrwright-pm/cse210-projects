using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("John Doe", "Algebra", "5.2", "1-10");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        
        WritingAssignment writing = new WritingAssignment("Jane Doe", "English", "My Essay");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}