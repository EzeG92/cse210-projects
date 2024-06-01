using System;

class StationaryBicycle : Activity
{
    private double _speed;

    public StationaryBicycle (DateTime date, int lengthInMinutes, double speed) : base (date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (LengthInMinutes / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}";
    }
}