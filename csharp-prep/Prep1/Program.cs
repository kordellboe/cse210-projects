using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        String firstname = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        String lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}");
    }

}