using System;
using System.IO; 
using System.Globalization;

class Journal
{
    
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string response, string prompt, DateTime date)
    {
        _entries.Add(new Entry { _promptText = prompt, _entryText = response, Date = date.ToString("yyyy-MM-dd") });
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();

        string filePath = Path.Combine(Environment.CurrentDirectory, filename);

        using (StreamWriter file = new StreamWriter(filePath))
        {
            foreach (Entry entry in _entries)
            {
                file.WriteLine($"{entry.Date} | {entry._promptText} | {entry._entryText}");
            }
        }
        Console.WriteLine("Saved successfully!");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();
        string filePath = Path.Combine(Environment.CurrentDirectory, filename);

        if (!File.Exists(filePath))
        {
            Console.WriteLine("The file does not exist.");
            return;
        }

        _entries.Clear();

        using (StreamReader file = new StreamReader(filePath))
        {
            string line;
            while ((line = file.ReadLine())!= null)
            {
                string[] parts = line.Split('|');
                Entry entry = new Entry();
                entry.Date = parts[0].Trim();
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Loaded successfully!");
    }
}