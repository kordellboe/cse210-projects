using System;

class Program
{
    static void Main(string[] args)
    {
        int num;
        List<int> numbers = new List<int>();
        do
        {
            Console.Write("Enter a number:");
            string number = Console.ReadLine();
            num = int.Parse(number);
            if (0 != num)
            {
                numbers.Add(num);
            }
        }

        while (num != 0);



        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }






    }
}