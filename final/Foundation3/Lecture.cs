using System;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture (string title, string description, string date, string time, Address address, string speaker, int capacity ) : base (title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetStandarDetails() + "\n\n" + "Speaker: " + _speaker + "\n\n" + "Capacity "+ _capacity + " attendes.";
    }

    public override string GetShortDescription()
    {
        return "TYPE OF EVENT: Lecture\n" + "TITLE: " + Title + "\n" + "DATE: " + Date;
    }
}