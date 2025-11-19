using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are some personal strengths you have?",
        "Who have you helped this week?",
        "Who are your heroes?"
    };

    public ListingActivity()
        : base("Listing Activity",
               "This activity helps you list as many positive things as you can.")
    {
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();
        int index = rand.Next(_prompts.Count);

        Console.Clear();
        Console.WriteLine("Prompt:");
        Console.WriteLine(_prompts[index]);
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        Countdown(5);

        int time = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(time);

        List<string> items = new List<string>();

        Console.WriteLine("Start listing now!");

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine("You listed " + items.Count + " things!");

        EndActivity();
    }
}
