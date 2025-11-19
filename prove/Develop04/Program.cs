using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity a = new BreathingActivity();
                a.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity a = new ReflectionActivity();
                a.Run();
            }
            else if (choice == "3")
            {
                ListingActivity a = new ListingActivity();
                a.Run();
            }
            else if (choice == "4")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                Console.ReadLine();
            }
        }
    }
}
