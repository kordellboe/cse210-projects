using System;
using System.Collections.Generic;

public class ReflectionActivity : MindfulnessActivity
{
    private readonly List<string> _prompts = new List<string>
    {
        "Think of a time you helped someone.",
        "Recall a moment you felt proud.",
        "Remember a time you learned something hard.",
        "Think of a small win from this week.",
        "Recall a time you showed courage."
    };

    private readonly List<string> _questions = new List<string>
    {
        "Why was this moment meaningful?",
        "What did you learn about yourself?",
        "How can you use this tomorrow?",
        "Who else was affected and how?",
        "What would you do the same next time?"
    };

    public ReflectionActivity()
    {
        ActivityName = "Reflection Activity";
        Description = "Reflect on a prompt and consider simple questions.";
    }

    public void RunReflectionSession()
    {
        var rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Press Enter to begin thinking.");
        Console.ReadLine();

        int timePerQuestion = 5;
        int total = 0;
        int i = 0;

        while (total < DurationInSeconds)
        {
            string q = _questions[i % _questions.Count];
            Console.WriteLine(q);
            int step = Math.Min(timePerQuestion, DurationInSeconds - total);
            ShowCountdown(step);
            total += step;
            i++;
        }
    }
}
