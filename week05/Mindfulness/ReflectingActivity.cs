using System;
using System.Collections.Generic;

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
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(5);
            Console.WriteLine();
        }
    }
}