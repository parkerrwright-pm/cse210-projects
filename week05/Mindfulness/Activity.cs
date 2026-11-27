using System;
using System.Threading;
using System.Diagnostics;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long would you like to do this activity, in seconds? ");

        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Please enter a positive number: ");
        }

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You completed {_duration} seconds of the {_name}.");
        ShowSpinner(3);
        Console.WriteLine();
    }

    protected TimeSpan GetRemainingTime(Stopwatch timer)
    {
        TimeSpan remaining = TimeSpan.FromSeconds(_duration) - timer.Elapsed;
        return remaining > TimeSpan.Zero ? remaining : TimeSpan.Zero;
    }

    public void ShowSpinner(int seconds)
    {
        ShowSpinner(TimeSpan.FromSeconds(seconds));
    }

    protected void ShowSpinner(TimeSpan duration)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        Stopwatch timer = Stopwatch.StartNew();
        int frame = 0;

        while (timer.Elapsed < duration)
        {
            Console.Write(spinner[frame++ % spinner.Length]);
            Pause(duration - timer.Elapsed, 250);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        ShowCountDown(TimeSpan.FromSeconds(seconds));
    }

    protected void ShowCountDown(TimeSpan duration)
    {
        Stopwatch timer = Stopwatch.StartNew();

        while (timer.Elapsed < duration)
        {
            TimeSpan remaining = duration - timer.Elapsed;
            string number = Math.Ceiling(remaining.TotalSeconds).ToString();
            Console.Write(number);
            Pause(remaining, 1000);
            Console.Write(new string('\b', number.Length));
            Console.Write(new string(' ', number.Length));
            Console.Write(new string('\b', number.Length));
        }
    }

    private void Pause(TimeSpan remaining, int maximumMilliseconds)
    {
        if (remaining > TimeSpan.Zero)
        {
            Thread.Sleep(TimeSpan.FromMilliseconds(
                Math.Min(remaining.TotalMilliseconds, maximumMilliseconds)));
        }
    }
}
