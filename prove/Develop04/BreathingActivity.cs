using System;
using System.Collections.Generic;

// Define a new class called BreathingActivity that inherits from the Activity class
class BreathingActivity : Activity
{
    // Define a constructor that takes in a name and description for the activity
    public BreathingActivity(string name, string description) : base(name, description)
    {
        // Call the base class constructor with the provided name and description
    }

    // Define a method called Run that contains the main logic for the activity
    public void Run() 
    {
        // Initialize a variable called timeElapsed to keep track of how much time has elapsed
        int timeElapsed = 0;
        // Loop until the time elapsed is greater than or equal to the duration of the activity
        while (timeElapsed < _duration)
        {
            // If the time elapsed is divisible by 2, perform the breathing exercise
            if (timeElapsed % 2 == 0)
            {
                Console.WriteLine();

                Console.Write($"Breathe in...");
                ShowCountDown(4); // wait for 4 second
                timeElapsed +=4;
                
                Console.WriteLine();

                Console.Write("Breathe out...");
                ShowCountDown(6); //wait for 6 second
                timeElapsed +=6;

                Console.WriteLine();
            }
        }
        Console.WriteLine();
        // Call the DisplayEndingMessage method to print a message to the console indicating that the activity has ended
        DisplayEndingMessage();
    }
}