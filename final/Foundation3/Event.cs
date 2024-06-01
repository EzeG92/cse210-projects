using System;

public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event (string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public string GetStandarDetails()
    {
        return _title.ToUpper() + "\n" + _description + "\n\n" + "DATE AND TIME\n" + _date + " / " + _time + "\n\n" + "ADDRESS\n" + _address;
    }

    public abstract string GetFullDetails();

    public abstract string GetShortDescription();
}
