using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user for their name.
        Console.WriteLine("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"write your name {lastName}, {firstName} {lastName}.");

    }
}

