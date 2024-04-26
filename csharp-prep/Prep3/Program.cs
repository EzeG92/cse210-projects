using System;

class Program
{
    static void Main(string[] args)
    {
        int myGuess = -1;
        int guessCount = 0;
        string keepPlaying = "yes";

    while (keepPlaying == "yes" || keepPlaying == "Yes")
    {
        Console.WriteLine("Generating random number...");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        while (myGuess != number)
        {
            Console.Write("What is your guess? ");
            string inputGuess = Console.ReadLine();
            myGuess = int.Parse(inputGuess);
            guessCount++;

            if (myGuess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (myGuess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }   
        Console.WriteLine($"It took you {guessCount} guesses");
        Console.Write("Do you want to play again? yes/no: ");
        keepPlaying = Console.ReadLine();
    }

    Console.WriteLine("Thank you for playing. Goodbye");

    }
}