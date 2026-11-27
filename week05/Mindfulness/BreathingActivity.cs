using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by breathing in and out slowly.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Stopwatch timer = Stopwatch.StartNew();

        while (GetRemainingTime(timer) > TimeSpan.Zero)
        {
            TimeSpan remaining = GetRemainingTime(timer);
            TimeSpan pause = TimeSpan.FromSeconds(4);

            if (remaining < pause)
            {
                pause = remaining;
            }

            Console.Write("Breathe in... ");
            ShowCountDown(pause);
            Console.WriteLine();

            remaining = GetRemainingTime(timer);
            if (remaining > TimeSpan.Zero)
            {
                pause = TimeSpan.FromSeconds(4);

                if (remaining < pause)
                {
                    pause = remaining;
                }

                Console.Write("Breathe out... ");
                ShowCountDown(pause);
                Console.WriteLine();
            }
        }

        DisplayEndingMessage();
    }
}