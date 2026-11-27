using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life.")
    {
        _count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are some of your personal strengths?",
            "Who have you helped this week?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to this prompt:");
        GetRandomPrompt();

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> items = GetListFromUser();
        _count = items.Count;

        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        int index = Random.Shared.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[index]} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        StringBuilder response = new StringBuilder();
        Stopwatch timer = Stopwatch.StartNew();
        Console.Write("> ");

        while (GetRemainingTime(timer) > TimeSpan.Zero)
        {
            if (Console.IsInputRedirected)
            {
                // Redirected input is used for files and automated checks.
                string line = Console.ReadLine();
                if (line == null)
                {
                    break;
                }
                if (GetRemainingTime(timer) > TimeSpan.Zero && !string.IsNullOrWhiteSpace(line))
                {
                    items.Add(line);
                }
                continue;
            }

            if (!Console.KeyAvailable)
            {
                Thread.Sleep(20);
                continue;
            }

            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter)
            {
                if (!string.IsNullOrWhiteSpace(response.ToString()))
                {
                    items.Add(response.ToString());
                }
                response.Clear();
                Console.WriteLine();
                Console.Write("> ");
            }
            else if (key.Key == ConsoleKey.Backspace && response.Length > 0)
            {
                response.Length--;
                Console.Write("\b \b");
            }
            else if (!char.IsControl(key.KeyChar))
            {
                response.Append(key.KeyChar);
                Console.Write(key.KeyChar);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Time is up. Only responses submitted with Enter are counted.");
        return items;
    }
}
