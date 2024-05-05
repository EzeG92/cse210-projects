using System;

class Entry
{
    private DateTime _date;

    public string _promptText { get; set; }
    public string _entryText { get; set; }

    public string Date 
    { 
        get { return _date.ToString("yyyy-MM-dd"); } 
        set { _date = DateTime.ParseExact(value, "yyyy-MM-dd", null); } 
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date} - Prompt: {_promptText}\n{_entryText}\n");
    }
}

