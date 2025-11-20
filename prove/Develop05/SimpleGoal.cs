using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool isComplete)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine("You completed the goal and earned " + _points + " points.");
            return _points;
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStatusString()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";
        return checkbox + " " + _name + " (" + _description + ")";
    }

    public override string GetStringRepresentation()
    {
        return "SimpleGoal:" + _name + "|" + _description + "|" + _points + "|" + _isComplete;
    }
}
