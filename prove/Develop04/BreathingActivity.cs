using System;
using System.Threading;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        ActivityName = "Breathing";
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void RunBreathingSession()
    {
        int elapsedTime = 0;
        while (elapsedTime < DurationInSeconds)
        {
            int remainingTime = DurationInSeconds - elapsedTime;

            Console.WriteLine("Breathe in...");
            if (remainingTime >= 3)
            {
                ShowCountdown(3);
                elapsedTime += 3;
            }
            else
            {
                ShowCountdown(remainingTime);
                elapsedTime += remainingTime;
                break;
            }

            remainingTime = DurationInSeconds - elapsedTime;

            Console.WriteLine("Breathe out...");
            if (remainingTime >= 3)
            {
                ShowCountdown(3);
                elapsedTime += 3;
            }
            else
            {
                ShowCountdown(remainingTime);
                elapsedTime += remainingTime;
                break;
            }
        }
    }

}