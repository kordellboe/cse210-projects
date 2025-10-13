using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Whats your precentage?");
        string gradePerecentage = Console.ReadLine();
        int grade = int.Parse(gradePerecentage);
        string letter = "";

        if (grade >= 90)
        {
            //  Console.WriteLine("You got an A");
            letter = "A";
        }
        else if (grade >= 80)
        {
            //Console.WriteLine("You got a B");
            letter = "B";
        }
        else if (grade >= 70)
        {
            //Console.WriteLine("You got a C");
            letter = "C";
        }
        else if (grade >= 60)
        {
            //Console.WriteLine("You got a D");
            letter = "D";
        }
        else
        {
            //Console.WriteLine("You got an F");
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time");
        }


    }
}