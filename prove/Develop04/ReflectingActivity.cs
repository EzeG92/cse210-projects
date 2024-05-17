using System;
using System.Collections.Generic;

// Define a new class called ReflectingActivity that inherits from the Activity class
class ReflectingActivity : Activity
{
    // Create two private lists to store prompts and questions
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    // Define a constructor that takes a name and description as parameters
    public ReflectingActivity(string name, string description) :base (name, description)
    {

    }

    // Define a method called Run that displays a random prompt and a series of questions related to the prompt
    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:\n");

        DisplayPrompt();

        Console.Write("When you have something in mind, press enter to continue.");
        string choice = Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(4);

        Console.Clear();

        DisplayQuestions();

        Console.WriteLine();
        DisplayEndingMessage();
    }

    // Define a method called GetRandomPrompt that returns a random prompt from the list of prompts
    public string GetRandomPrompt()
    {
        _prompts.Add("--- Think of a time when you stood up for someone else. ---");
        _prompts.Add("--- Think of a time when you did something really difficult. ---");
        _prompts.Add("--- Think of a time when you helped someone in need. ---");
        _prompts.Add("--- Think of a time when you did something truly selfless. ---");

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    // Define a method called GetRandomQuestion that returns a random question from the list of questions
    // If there are no more questions, reset the list
    public string GetRandomQuestion()
    {
        if (_questions.Count == 0)
        {
            _questions = new List<string>
            {
                "> Why was this experience meaningful to you? ",
                "> Have you ever done anything like this before? ",
                "> How did you get started? ",
                "> How did you feel when it was complete? ",
                "> What made this time different than other times when you were not as successful? ",
                "> What is your favorite thing about this experience? ",
                "> What could you learn from this experience that applies to other situations? ",
                "> What did you learn about yourself through this experience? ",
                "> How can you keep this experience in mind in the future? "
            };
        }

        Random random = new Random();
        int index = random.Next(_questions.Count);
        string question = _questions[index];
        _questions.RemoveAt(index);
        return question;
    }

    // Define a method called DisplayPrompt that displays a random prompt
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine();
    }

    // Define a method called DisplayQuestions that displays a series of questions related to the prompt
    public void DisplayQuestions()
    {
        int timeElapsed = 0;

        while (timeElapsed < _duration)
        {
            {
                string question = GetRandomQuestion();
                Console.Write(question);
                ShowSpinner(1);
                ShowSpinner(1);
                ShowSpinner(1);
                Console.WriteLine();
                timeElapsed += 12;
            }
        }
    }
}   


