using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity helps you relax by breathing in and out slowly.")
    {
    }

    public void Run()
    {
        StartActivity();

        int time = GetDuration();
        int passed = 0;

        while (passed < time)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            Countdown(4);
            passed += 4;

            if (passed >= time)
            {
                break;
            }

            Console.Write("Breathe out... ");
            Countdown(4);
            passed += 4;
        }

        EndActivity();
    }
}
