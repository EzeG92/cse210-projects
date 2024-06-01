using System;

class Reception : Event
{
    private string _rsvpEmail;

    public Reception (string title, string description, string date, string time, Address address, string rsvpEmail) : base (title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return base.GetStandarDetails() + "\n\n" + "RSVP Email\n" + _rsvpEmail;
    }

    public override string GetShortDescription()
    {
        return "TYPE OF EVENT: Reception\n" + "TITLE: " + Title + "\n" + "DATE: " + Date;
    }
}
