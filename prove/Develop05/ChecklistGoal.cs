using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int currentCount)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = currentCount;
    }

    public override int RecordEvent()
    {
        _currentCount += 1;
        int total = _points;
        Console.WriteLine("Event recorded. You earned " + _points + " points.");

        if (_currentCount >= _targetCount)
        {
            Console.WriteLine("You completed the checklist goal and earned a bonus of " + _bonusPoints + " points!");
            total += _bonusPoints;
        }

        return total;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetStatusString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return checkbox + " " + _name + " (" + _description + ") - Completed " + _currentCount + "/" + _targetCount;
    }

    public override string GetStringRepresentation()
    {
        return "ChecklistGoal:" + _name + "|" + _description + "|" + _points + "|" + _targetCount + "|" + _bonusPoints + "|" + _currentCount;
    }
}
