using System;
using System.Net.Http.Headers;


class Program

{
    static void Main(string[] args)
    {
        int choice = 1;
        Console.WriteLine("Welcome!");

        Journal myJournal = new Journal();

        while (choice >=0 || choice < 0)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");

            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            choice = int.Parse(userInput);
    
            if (choice == 1)
            {
                PromptGenerator promptGenerator = new PromptGenerator();
                promptGenerator._prompts.Add("Who was the most interesting person I interacted with today? ");
                promptGenerator._prompts.Add("What was the best part of my day? ");
                promptGenerator._prompts.Add("How did I see the hand of the Lord in my life today? ");
                promptGenerator._prompts.Add("What was the strongest emotion I felt today? ");
                promptGenerator._prompts.Add("If I had one thing I could do over today, what would it be? ");

                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.Write(randomPrompt);
                string response = Console.ReadLine();
                myJournal.AddEntry(response, randomPrompt, DateTime.Now);
                
            }
            else if (choice == 2)
            {
                myJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                myJournal.LoadFromFile();
                myJournal.DisplayAll();
            }
            else if (choice == 4)
            {
                myJournal.SaveToFile();
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
        }

    }
}