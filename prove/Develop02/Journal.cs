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
                file.WriteLine($"Date: {entry.Date} - Prompt: {entry._promptText}\n{entry._entryText}\n");
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
            Entry entry = null;
            while ((line = file.ReadLine())!= null)
            {
                if (line.StartsWith("Date: "))
                {
                    if (entry!= null)
                    {
                        _entries.Add(entry);
                    }
                    entry = new Entry();
                    string[] parts = line.Split(new string[] { " - " }, StringSplitOptions.None);
                    DateTime date = DateTime.ParseExact(parts[0].Substring(5), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    entry.Date = date.ToString("yyyy-MM-dd");
                }
                else if (line.StartsWith("Prompt: "))
                {
                    string[] parts = line.Split(new string[] { " - " }, StringSplitOptions.None);
                    entry._promptText = parts[1];
                }
                else
                {
                    entry._entryText += line + Environment.NewLine;
                }
            }
            if (entry!= null)
            {
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Loaded successfully!");
    }

    

}