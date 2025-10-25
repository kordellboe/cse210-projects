using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Mindfulness Program");

        string choice = "";

        while (choice != "4")
        {
            Console.WriteLine("\nSelect an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity a = new BreathingActivity();
                a.StartActivity();
                a.RunBreathingSession();
                a.EndActivity();
            }
            else if (choice == "2")
            {
                ReflectionActivity a = new ReflectionActivity();
                a.StartActivity();
                a.RunReflectionSession();
                a.EndActivity();
            }
            else if (choice == "3")
            {
                ListingActivity a = new ListingActivity();
                a.StartActivity();
                a.RunListActivity();
                a.EndActivity();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
