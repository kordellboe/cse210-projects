using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        ActivityName = "Breathing Activity";
        Description = "Breathe in and out slowly. Focus on your breath.";
    }

    public void RunBreathingSession()
    {
        int elapsedTime = 0;
        while (elapsedTime < DurationInSeconds)
        {
            int remainingTime = DurationInSeconds - elapsedTime;

            Console.WriteLine("Breathe in...");
            int step = Math.Min(3, remainingTime);
            ShowCountdown(step);
            elapsedTime += step;
            if (elapsedTime >= DurationInSeconds) break;

            remainingTime = DurationInSeconds - elapsedTime;
            Console.WriteLine("Breathe out...");
            step = Math.Min(3, remainingTime);
            ShowCountdown(step);
            elapsedTime += step;
        }
    }
}
