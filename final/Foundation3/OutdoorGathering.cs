using System;

class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering (string title, string description, string date, string time, Address address, string weather) : base (title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        return base.GetStandarDetails() + "\n\n" + _weather;
    }

    public override string GetShortDescription()
    {
        return "TYPE OF EVENT: Outdoor Gathering\n" + "TITLE: " + Title + "\n" + "DATE: " + Date;
    }
}