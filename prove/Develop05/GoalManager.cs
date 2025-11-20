using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest");
            Console.WriteLine("Score: " + _score);
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoals();
                Pause();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option.");
                Pause();
            }
        }
    }

    private void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Types of Goals:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
        Console.Write("Which type of goal would you like to create? ");
        string input = Console.ReadLine();

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter a short description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the number of points: ");
        int points = int.Parse(Console.ReadLine());

        if (input == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (input == "2")
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (input == "3")
        {
            Console.Write("Enter the target number of times: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter the bonus points for completing it: ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);
        }
        else
        {
            Console.WriteLine("Unknown type.");
            Pause();
        }
    }

    private void ListGoals()
    {
        Console.Clear();
        Console.WriteLine("Your goals:");
        Console.WriteLine();

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }

        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(index + ". " + goal.GetStatusString());
            index++;
        }
    }

    private void SaveGoals()
    {
        Console.Write("Enter a file name: ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
        Pause();
    }

    private void LoadGoals()
    {
        Console.Write("Enter a file name: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            Pause();
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(':');
            string type = parts[0];
            string data = parts[1];
            string[] info = data.Split('|');

            if (type == "SimpleGoal")
            {
                string name = info[0];
                string description = info[1];
                int points = int.Parse(info[2]);
                bool done = bool.Parse(info[3]);

                SimpleGoal g = new SimpleGoal(name, description, points, done);
                _goals.Add(g);
            }
            else if (type == "EternalGoal")
            {
                string name = info[0];
                string description = info[1];
                int points = int.Parse(info[2]);

                EternalGoal g = new EternalGoal(name, description, points);
                _goals.Add(g);
            }
            else if (type == "ChecklistGoal")
            {
                string name = info[0];
                string description = info[1];
                int points = int.Parse(info[2]);
                int target = int.Parse(info[3]);
                int bonus = int.Parse(info[4]);
                int current = int.Parse(info[5]);

                ChecklistGoal g = new ChecklistGoal(name, description, points, target, bonus, current);
                _goals.Add(g);
            }
        }

        Console.WriteLine("Goals loaded.");
        Pause();
    }

    private void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            Pause();
            return;
        }

        ListGoals();
        Console.WriteLine();
        Console.Write("Which goal number? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid option.");
            Pause();
            return;
        }

        Goal goal = _goals[index];
        int earned = goal.RecordEvent();
        _score += earned;

        Console.WriteLine("Total score: " + _score);
        Pause();
    }

    private void Pause()
    {
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
    }
}
