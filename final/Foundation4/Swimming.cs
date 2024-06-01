using System;

class Swimming : Activity
{
    private int _laps;
    private const double _lapDistance = 50.0 / 1609.34;

    public Swimming (DateTime date, int lengthInMinutes, int laps) : base (date, lengthInMinutes)
    {
        _laps = laps;
    } 

    public override double GetDistance()
    {
        return _laps * _lapDistance;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (LengthInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return LengthInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}";
    }
}