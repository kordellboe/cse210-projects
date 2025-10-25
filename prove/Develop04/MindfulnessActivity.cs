using System;
using System.Threading;

public class MindfulnessActivity
{
    public string ActivityName { get; set; }
    public string Description { get; set; }
    public int DurationInSeconds { get; set; }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine(ActivityName);
        Console.WriteLine(Description);
        Console.Write("Duration in seconds: ");
        int seconds;
        if (!int.TryParse(Console.ReadLine(), out seconds) || seconds < 1) seconds = 30;
        DurationInSeconds = seconds;
        Console.WriteLine("Get ready...");
        ShowCountdown(3);
        Console.Clear();
    }

    public void EndActivity()
    {
        Console.WriteLine($"Well done. You completed {ActivityName} for {DurationInSeconds} seconds.");
        ShowCountdown(2);
        Console.Clear();
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}
