using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    protected void AddPoints(int points)
    {
        int currentPoints = int.Parse(_points);
        int newPoints = currentPoints + points;
        _points = newPoints.ToString();
    }
    
    public abstract int GetPoints();

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"[] {_shortName} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }
}