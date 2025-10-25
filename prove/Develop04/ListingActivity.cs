using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    private readonly List<string> _topics = new List<string>
    {
        "List people you appreciate.",
        "List places that calm you.",
        "List good things that happened today.",
        "List goals you can start this week.",
        "List skills you’re grateful to have."
    };

    public ListingActivity()
    {
        ActivityName = "Listing Activity";
        Description = "List as many items as you can for a simple topic.";
    }

    public void RunListActivity()
    {
        var rand = new Random();
        string topic = _topics[rand.Next(_topics.Count)];
        Console.WriteLine($"Topic: {topic}");
        Console.WriteLine("Start listing. Press Enter after each item. Time is running...");
        var items = new List<string>();

        DateTime end = DateTime.Now.AddSeconds(DurationInSeconds);
        while (DateTime.Now < end)
        {
            if (Console.KeyAvailable)
            {
                string line = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(line)) items.Add(line.Trim());
            }
        }

        Console.WriteLine($"Items listed: {items.Count}");
        foreach (var it in items) Console.WriteLine($"- {it}");
    }
}
