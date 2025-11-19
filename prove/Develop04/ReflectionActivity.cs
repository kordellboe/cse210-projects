using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you helped someone.",
        "Think of a time you did something hard.",
        "Think of a time you were proud of yourself.",
        "Think of a time you stood up for someone."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did it start?",
        "How did it make you feel?",
        "What did you learn?",
        "Why was this different from other times?",
        "What can you take from this in the future?"
    };

    public ReflectionActivity()
        : base("Reflection Activity",
               "This activity helps you think deeply about strong moments in your life.")
    {
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();

        Console.Clear();
        Console.WriteLine("Prompt:");
        Console.WriteLine();

        int promptIndex = rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[promptIndex]);
        Console.WriteLine();
        Console.WriteLine("Press enter when ready.");
        Console.ReadLine();

        int time = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(time);

        Console.WriteLine();
        Console.WriteLine("Reflect on the following questions:");

        while (DateTime.Now < end)
        {
            int q = rand.Next(_questions.Count);
            Console.WriteLine(_questions[q]);
            ShowSpinner(5);
        }

        EndActivity();
    }
}
