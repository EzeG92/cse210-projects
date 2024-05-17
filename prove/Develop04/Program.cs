using System;

// Exceeding Requirements: I added a counter in the Class program to count how many times the activities were done, when you choose option 4 to quit, it shows the number of activities carried out.
class Program
{
    // This variable keeps track of the number of activities that have been completed
    static int activityCount = 0;
    static void Main(string[] args)
    {
        int choice = 1;

        Console.Clear();

        // Loop until the user chooses to quit
        while(choice >=0 || choice < 0)
        {
            // Display the menu options
            Console.WriteLine("Menu Options:\n");
            Console.WriteLine("1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit\n");

            // Get the user's choice
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            choice = int.Parse(userInput);

            // If the user chooses to start the breathing activity
            if (choice == 1)
            {
                Console.Clear();

                // Create a new BreathingActivity object
                BreathingActivity ac1 = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

                ac1.DisplayStartingMessage();
                ac1.ShowSpinner(1);
                ac1.Run();
                Console.Clear();
                activityCount++;
            }

            // If the user chooses to start the reflecting activity
            if (choice == 2)
            {
                Console.Clear();

                // Create a new ReflectingActivity object
                ReflectingActivity ac2 = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                ac2.DisplayStartingMessage();
                ac2.ShowSpinner(1);
                ac2.Run();
                Console.Clear();
                activityCount++;
            }

            // If the user chooses to start the listing activity
            if (choice == 3)
            {
                Console.Clear();

                // Create a new ListingActivity object
                ListingActivity ac3 = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                ac3.DisplayStartingMessage();
                ac3.ShowSpinner(1);
                ac3.Run();
                Console.Clear();
                activityCount++;
            }

            // If the user chooses to quit
            if (choice == 4)
            {
                // Display a thank you message and the number of activities completed
                Console.WriteLine("Thank you for using our application! You have done " + activityCount + " activities. Goodbye.");
                // Break out of the loop
                break;
            }
        }
    }
}