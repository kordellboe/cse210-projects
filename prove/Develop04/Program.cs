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
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.StartActivity();
                breathingActivity.RunBreathingSession();
                breathingActivity.EndActivity();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.StartActivity();
                reflectionActivity.RunReflectionSession();
                reflectionActivity.EndActivity();
            }
            else if (choice == "3")
            {
                ListingActivity listActivity = new ListingActivity();
                listActivity.StartActivity();
                listActivity.RunListActivity();
                listActivity.EndActivity();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid activity.");
            }
        }
    }
}