using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

class Activity
{
    // Private field to store the activity name
    private string _name;
    // Private field to store the activity description
    private string _description;
    // Protected field to store the activity duration in seconds
    protected int _duration;

    public Activity (string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Displays a starting message to the user and prompts for the activity duration
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
        Console.Clear();
        Console.WriteLine("Get Ready...");
    }

    // Displays an ending message to the user after the activity is completed
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
        ShowSpinner(1);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(1);
    }

    // Displays a spinner animation for a specified number of seconds
    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        foreach (string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(seconds*500);
            Console.Write("\b \b");
        }
    }
    
    // Displays a countdown timer for a specified number of seconds
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}