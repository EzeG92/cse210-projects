using System;
using System.Collections.Generic;

// Define a new class called ListingActivity that inherits from the Activity class
class ListingActivity : Activity
{
    // Initialize private fields for the count of items listed and a list of prompts
    private int _count;
    private List<string> _prompts = new List<string>();

    // Constructor that takes a name and description and passes them to the base class constructor
    public ListingActivity(string name, string description) :base (name, description)
    {
        
    }

    // Method to run the listing activity
    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt: ");

        // Get a random prompt from the list of prompts
        GetRandomPrompt();

        // Write a prompt to the console to begin in 4 seconds
        Console.Write("You may begin in: ");
        ShowCountDown(4);

        Console.WriteLine();

        // Get a list of items from the user
        GetListFromUser();

        Console.WriteLine();
        // Display an ending message
        DisplayEndingMessage();
    }

    // Method to get a random prompt from the list of prompts
    public void GetRandomPrompt()
    {
        // Add some prompts to the list of prompts
        _prompts.Add("--- Who are people that you appreciate? ---");
        _prompts.Add("--- What are personal strengths of yours? ---");
        _prompts.Add("--- Who are people that you have helped this week? ---");
        _prompts.Add("--- When have you felt the Holy Ghost this month? ---");
        _prompts.Add("--- Who are some of your personal heroes? ---");

        Random random = new Random();
        // Get a random index from the list of prompts
        int index = random.Next(_prompts.Count);
        // Get the prompt at the random index
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
    }

    // Method to get a list of items from the user
    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        // Get the current date and time
        DateTime startTime = DateTime.Now;
        // Calculate the end time by adding the duration to the start time
        DateTime endTime = startTime.AddSeconds(_duration);

        // Loop until the current time is greater than the end time
        while (DateTime.Now <= endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (input == "")
            {
                break;
            }
            else
            {
                // Add the input to the list of items
                list.Add(input);
                // Increment the count of items
                _count++;
            }
        }
        // Write a message to the console with the number of items listed
        Console.WriteLine($"You listed {_count} items!");
        return list;
    }
}