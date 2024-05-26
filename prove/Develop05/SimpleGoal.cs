using System;

class SimpleGoal : Goal
{

    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int GetPoints()
    {
        return int.Parse(_points);
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation() //details to save to a file
    {
        return $"SimpleGoal,{base.GetStringRepresentation()},{_isComplete}";
    }

    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }
}