using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
        : base(
            "Reflecting Activity",
            "This activity will help you reflect on times when you showed strength.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you helped someone.",
            "Think of a time when you did something difficult.",
            "Think of a time when you stood up for someone."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself?",
            "How did this experience help you grow?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();

        Console.WriteLine("Think about this experience.");
        ShowSpinner(5);
        Console.WriteLine();

        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = Random.Shared.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        int index = Random.Shared.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions()
    {
        List<string> unusedQuestions = new List<string>(_questions);
        Stopwatch timer = Stopwatch.StartNew();
        string previousQuestion = "";

        while (GetRemainingTime(timer) > TimeSpan.Zero)
        {
            if (unusedQuestions.Count == 0)
            {
                unusedQuestions.AddRange(_questions);
            }

            int index = Random.Shared.Next(unusedQuestions.Count);

            if (unusedQuestions.Count > 1 &&
                unusedQuestions[index] == previousQuestion)
            {
                index = (index + 1) % unusedQuestions.Count;
            }
            // Ensure the question doesn't repeat.
            string question = unusedQuestions[index];
            unusedQuestions.RemoveAt(index);
            previousQuestion = question;

            Console.WriteLine($"> {question}");

            TimeSpan pause = TimeSpan.FromSeconds(15);
            TimeSpan remaining = GetRemainingTime(timer);

            if (remaining < pause)
            {
                pause = remaining;
            }

            ShowSpinner(pause);
            Console.WriteLine();
        }
    }
}