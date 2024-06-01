using System;
using System.Collections.Generic;

abstract class Activity
{
    private DateTime _date;
    private int _lengthInMinutes;

    public Activity (DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public int LengthInMinutes
    {
        get { return _lengthInMinutes; }
        set {_lengthInMinutes = value;}
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return  $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name} ({_lengthInMinutes} min) - " + 
                $"Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}