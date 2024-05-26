using System;

class EternalGoal : Goal
{
    
    public EternalGoal(string name, string description, string points) : base (name, description, points)
    {

    }

    public override int GetPoints()
    {
        return int.Parse(_points);
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation() //details to save to a file
    {
        return $"EternalGoal,"+base.GetStringRepresentation();
    }

}