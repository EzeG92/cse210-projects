using System;

class Running : Activity
{
    private double _distance;

    public Running (DateTime date, int lengthInMinutes, double distance) : base (date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (LengthInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return LengthInMinutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}";
    }
}